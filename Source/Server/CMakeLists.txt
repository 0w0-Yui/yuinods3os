# ================================================================================================
#  DS3OS
#  Copyright (C) 2021 Tim Leonard
# ================================================================================================

project(Server C CXX)

SET(SOURCES
    Entry.cpp

    Client/Client.cpp
    Client/Client.h

    Config/BuildConfig.h
    Config/RuntimeConfig.h
    Config/RuntimeConfig.cpp

    Protobuf/FpdLogMessage.cc
    Protobuf/Frpg2PlayerData.cc
    Protobuf/Frpg2RequestMessage.cc
    Protobuf/Protobufs.h
    
    Server/Server.cpp
    Server/Server.h
    Server/Service.h
    Server/AuthService/AuthClient.cpp
    Server/AuthService/AuthClient.h
    Server/AuthService/AuthService.cpp
    Server/AuthService/AuthService.h
    Server/Database/DatabaseTypes.h
    Server/Database/ServerDatabase.cpp
    Server/Database/ServerDatabase.h
    Server/GameService/GameClient.cpp
    Server/GameService/GameClient.h
    Server/GameService/GameManager.h
    Server/GameService/GameService.cpp
    Server/GameService/GameService.h
    Server/GameService/PlayerState.h
    Server/GameService/GameManagers/BloodMessage/BloodMessageManager.cpp
    Server/GameService/GameManagers/BloodMessage/BloodMessageManager.h
    Server/GameService/GameManagers/Bloodstain/BloodstainManager.cpp
    Server/GameService/GameManagers/Bloodstain/BloodstainManager.h
    Server/GameService/GameManagers/Boot/BootManager.cpp
    Server/GameService/GameManagers/Boot/BootManager.h
    Server/GameService/GameManagers/BreakIn/BreakInManager.cpp
    Server/GameService/GameManagers/BreakIn/BreakInManager.h
    Server/GameService/GameManagers/Ghosts/GhostManager.cpp
    Server/GameService/GameManagers/Ghosts/GhostManager.h
    Server/GameService/GameManagers/Logging/LoggingManager.cpp
    Server/GameService/GameManagers/Logging/LoggingManager.h
    Server/GameService/GameManagers/Mark/MarkManager.cpp
    Server/GameService/GameManagers/Mark/MarkManager.h
    Server/GameService/GameManagers/Misc/MiscManager.cpp
    Server/GameService/GameManagers/Misc/MiscManager.h
    Server/GameService/GameManagers/PlayerData/PlayerDataManager.cpp
    Server/GameService/GameManagers/PlayerData/PlayerDataManager.h
    Server/GameService/GameManagers/QuickMatch/QuickMatchManager.cpp
    Server/GameService/GameManagers/QuickMatch/QuickMatchManager.h
    Server/GameService/GameManagers/Ranking/RankingManager.cpp
    Server/GameService/GameManagers/Ranking/RankingManager.h
    Server/GameService/GameManagers/Signs/SignManager.cpp
    Server/GameService/GameManagers/Signs/SignManager.h
    Server/GameService/GameManagers/Visitor/VisitorManager.cpp
    Server/GameService/GameManagers/Visitor/VisitorManager.h
    Server/GameService/GameManagers/AntiCheat/AntiCheatManager.cpp
    Server/GameService/GameManagers/AntiCheat/AntiCheatManager.h
    Server/GameService/GameManagers/AntiCheat/AntiCheatTrigger.cpp
    Server/GameService/GameManagers/AntiCheat/AntiCheatTrigger.h
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_ClientFlagged.cpp
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_ClientFlagged.h
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_Exploit.cpp
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_Exploit.h
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_ImpossibleStats.cpp
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_ImpossibleStats.h
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_InvalidName.cpp
    Server/GameService/GameManagers/AntiCheat/Triggers/AntiCheatTrigger_InvalidName.h
    Server/GameService/Utils/GameIds.h
    Server/GameService/Utils/NRSSRSanitizer.h
    Server/GameService/Utils/OnlineAreaPool.h
    Server/GameService/Utils/Ids/BonfireId.inc
    Server/GameService/Utils/Ids/CharacterTypeId.inc
    Server/GameService/Utils/Ids/ConvenantId.h
    Server/GameService/Utils/Ids/CovenantId.h
    Server/GameService/Utils/Ids/CovenantId.inc
    Server/GameService/Utils/Ids/GestureId.inc
    Server/GameService/Utils/Ids/InvasionTypeId.inc
    Server/GameService/Utils/Ids/ItemId.h
    Server/GameService/Utils/Ids/ItemId.inc
    Server/GameService/Utils/Ids/OnlineAreaId.inc
    Server/GameService/Utils/Ids/TeamTypeId.inc
    Server/GameService/Utils/Ids/BossId.inc    
    Server/GameService/Utils/Ids/BloodMessageConjunction.inc
    Server/GameService/Utils/Ids/BloodMessageGesture.inc
    Server/GameService/Utils/Ids/BloodMessageTemplate.inc
    Server/GameService/Utils/Ids/BloodMessageWord.inc    
    Server/GameService/Utils/Data/BloodMessageData.h
    Server/GameService/Utils/Data/BloodMessageData.cpp
    Server/LoginService/LoginClient.cpp
    Server/LoginService/LoginClient.h
    Server/LoginService/LoginService.cpp
    Server/LoginService/LoginService.h
    Server/Streams/Frpg2Message.h
    Server/Streams/Frpg2MessageStream.cpp
    Server/Streams/Frpg2MessageStream.h
    Server/Streams/Frpg2Packet.h
    Server/Streams/Frpg2PacketStream.cpp
    Server/Streams/Frpg2PacketStream.h
    Server/Streams/Frpg2ReliableUdpFragment.h
    Server/Streams/Frpg2ReliableUdpFragmentStream.cpp
    Server/Streams/Frpg2ReliableUdpFragmentStream.h
    Server/Streams/Frpg2ReliableUdpMessage.cpp
    Server/Streams/Frpg2ReliableUdpMessage.h
    Server/Streams/Frpg2ReliableUdpMessageStream.cpp
    Server/Streams/Frpg2ReliableUdpMessageStream.h
    Server/Streams/Frpg2ReliableUdpMessageTypes.inc
    Server/Streams/Frpg2ReliableUdpPacket.cpp
    Server/Streams/Frpg2ReliableUdpPacket.h
    Server/Streams/Frpg2ReliableUdpPacketStream.cpp
    Server/Streams/Frpg2ReliableUdpPacketStream.h
    Server/Streams/Frpg2UdpPacket.h
    Server/Streams/Frpg2UdpPacketStream.cpp
    Server/Streams/Frpg2UdpPacketStream.h
    Server/Streams/README
    Server/WebUIService/WebUIService.cpp
    Server/WebUIService/WebUIService.h
    Server/WebUIService/Handlers/AuthHandler.cpp
    Server/WebUIService/Handlers/AuthHandler.h
    Server/WebUIService/Handlers/DebugStatisticsHandler.cpp
    Server/WebUIService/Handlers/DebugStatisticsHandler.h
    Server/WebUIService/Handlers/MessageHandler.cpp
    Server/WebUIService/Handlers/MessageHandler.h
    Server/WebUIService/Handlers/BansHandler.cpp
    Server/WebUIService/Handlers/BansHandler.h
    Server/WebUIService/Handlers/PlayersHandler.cpp
    Server/WebUIService/Handlers/PlayersHandler.h
    Server/WebUIService/Handlers/SettingsHandler.cpp
    Server/WebUIService/Handlers/SettingsHandler.h
    Server/WebUIService/Handlers/StatisticsHandler.cpp
    Server/WebUIService/Handlers/StatisticsHandler.h
    Server/WebUIService/Handlers/WebUIHandler.cpp
    Server/WebUIService/Handlers/WebUIHandler.h
)
 
add_executable(${PROJECT_NAME} ${SOURCES} ${PLATFORM_SOURCES})

target_include_directories(${PROJECT_NAME} PUBLIC "${CMAKE_CURRENT_SOURCE_DIR}" "${CMAKE_CURRENT_SOURCE_DIR}/../")

target_compile_definitions(${PROJECT_NAME} PRIVATE -D_CRT_SECURE_NO_WARNINGS -D_WINSOCK_DEPRECATED_NO_WARNINGS -D_SILENCE_ALL_CXX17_DEPRECATION_WARNINGS)

target_link_libraries(
    ${PROJECT_NAME}
    Shared
    civetweb
    libprotobuf-lite
    sqlite
    steam
)

# Copy some important files over to our output directory.
foreach(config ${CMAKE_CONFIGURATION_TYPES})
    string(TOUPPER ${config} config_upper)
    
    # Write steam appid file, required for dedicated servers.
    file(WRITE "${CMAKE_RUNTIME_OUTPUT_DIRECTORY_${config_upper}}/steam_appid.txt" "374320")

    # Copy WebUI resources to output folder
    file(COPY "${CMAKE_CURRENT_SOURCE_DIR}/../WebUI" DESTINATION "${CMAKE_RUNTIME_OUTPUT_DIRECTORY_${config_upper}}")
endforeach()

util_setup_folder_structure(${PROJECT_NAME} SOURCES "DS3OS")
