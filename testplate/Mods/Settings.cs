using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;
using static StupidTemplate.Mods.Variables;
using UnityEngine;
using UnityEngine.UI;
using static StupidTemplate.Mods.MainMods;
using Photon.Pun;
using Steamworks;

namespace StupidTemplate.Mods
{
    internal class SettingsMods
    {
        public static string rom;
        public static void PCON()
        {
            isOnPC = true;
            wasdddd();
            GUI.Label(new Rect(0, Screen.height - 25, Screen.width, 40), "PC Mode On!");
            if (PhotonNetwork.InRoom)
            {
                rom = "IN ROOM: " + PhotonNetwork.CurrentRoom.Name;
                GUI.Label(new Rect(0, Screen.height - 45, Screen.width, 40), rom);
            }
        }

        public static void PCOFF()
        {
            isOnPC = false;
            GUI.Label(new Rect(0, Screen.height - 25, Screen.width, 40), "PC Mode Off!");
            if (PhotonNetwork.InRoom)
            {
                rom = "IN ROOM: " + PhotonNetwork.CurrentRoom.Name;
                GUI.Label(new Rect(0, Screen.height - 45, Screen.width, 40), rom);
            }
        }
        public static void EnterSettings()
        {
            buttonsType = 1;
        }

        public static void MenuSettings()
        {
            buttonsType = 2;
        }

        public static void MovementSettings()
        {
            buttonsType = 3;
        }

        public static void ProjectileSettings()
        {
            buttonsType = 4;
        }

        public static void MainMods()
        {
            buttonsType = 5;
        }

        public static void CoolMods()
        {
            buttonsType = 6;
        }

        public static void OPMods()
        {
            buttonsType = 7;
        }

        public static void SafetyMods()
        {
            buttonsType = 8;
        }

        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }
    }
}
