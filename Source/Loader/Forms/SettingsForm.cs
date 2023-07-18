using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loader.Utils;

namespace Loader
{
    public partial class SettingsForm : Form
    {
        public string ExeLocation = "";
        private bool DoNotSaveSettings = false;
        string[] settings = { "account_name.txt", "language.txt", "user_steam_id.txt" };
        string dataGoldberg = InstallationUtils.LoaderDataGoldberg;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DoNotSaveSettings = true;
            UseSeperateSavesCheckbox.Checked = ProgramSettings.Default.use_seperate_saves;
            DoNotSaveSettings = false;

            if (File.Exists(InstallationUtils.LoaderCacheGoldberg))
            {
                foreach (string setting in settings)
                {
                    if (setting == settings[0])
                        SteamUserNameText.Text = File.ReadAllText(String.Format("{0}\\{1}", dataGoldberg, settings[0]));
                    if (setting == settings[1])
                        GameLanguageText.Text = File.ReadAllText(String.Format("{0}\\{1}", dataGoldberg, settings[1]));
                    if (setting == settings[2])
                        Steam64IDText.Text = File.ReadAllText(String.Format("{0}\\{1}", dataGoldberg, settings[2]));
                }
            }
            else
            {
                SteamUserNameText.Text = "";
                GameLanguageText.Text = "tchinese";
                Steam64IDText.Text = "";
            }

            UpdateState();
        }

        private void UpdateState()
        {
            CopySavesButton.Enabled = ProgramSettings.Default.use_seperate_saves;
        }

        private void CopySavesClicked(object sender, EventArgs e)
        {
            string BasePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DarkSoulsIII";

            if (!Directory.Exists(BasePath))
            {
                MessageBox.Show("Failed to find existing save folder. Have you actually run the game before on retail?");
                return;
            }

            if (MessageBox.Show("This will overwrite any existing DS3OS saves that exist, are you sure you wish to do this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                return;
            }

            int FilesCopied = 0;

            string[] RetailFiles = System.IO.Directory.GetFiles(BasePath, "*.sl2", SearchOption.AllDirectories);
            foreach (string file in RetailFiles)
            {
                string NewPath = Path.ChangeExtension(file, ".ds3os");
                Console.WriteLine(file + " -> " + NewPath);

                File.Copy(file, NewPath, true);

                FilesCopied++;
            }

            MessageBox.Show("Copied " + FilesCopied.ToString() + " retail saves to ds3os.");
        }

        private void SettingChanged(object sender, EventArgs e)
        {
            if (DoNotSaveSettings)
            {
                return;
            }

            ProgramSettings.Default.use_seperate_saves = UseSeperateSavesCheckbox.Checked;
            ProgramSettings.Default.Save();

            UpdateState();
        }

        private void RestoreSteamButton_Click(object sender, EventArgs e)
        {
            InstallationUtils.RestoreSteam(ExeLocation);
        }

        private void SaveGoldBergSettingButton_Click(object sender, EventArgs e)
        {
            if (SteamUserNameText.Text == String.Empty || GameLanguageText.Text == String.Empty || Steam64IDText.Text == String.Empty)
            {
                MessageBox.Show("请填写所有字段", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach(string setting in settings)
                {
                    if (!File.Exists(String.Format("{0}\\{1}", dataGoldberg, setting)))
                        File.Create(String.Format("{0}\\{1}", dataGoldberg, setting)).Close();
                }
                File.WriteAllText(String.Format("{0}\\{1}", dataGoldberg, settings[0]), SteamUserNameText.Text);
                File.WriteAllText(String.Format("{0}\\{1}", dataGoldberg, settings[1]), GameLanguageText.Text);
                File.WriteAllText(String.Format("{0}\\{1}", dataGoldberg, settings[2]), Steam64IDText.Text);
                File.Create(InstallationUtils.LoaderCacheGoldberg).Close();
                MessageBox.Show("设置已保存", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
