using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;
using static StupidTemplate.Mods.Variables;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Made By Nexus <3", enableMethod =() => SettingsMods.PCON(), disableMethod =() => SettingsMods.PCOFF(), enabled = isOnPC, toolTip = "thanks for using <3"},
                new ButtonInfo { buttonText = "Main Mods", method =() => SettingsMods.MainMods(), isTogglable = false, toolTip = "Main mods for the menu."},
                new ButtonInfo { buttonText = "Cool Mods", method =() => SettingsMods.CoolMods(), isTogglable = false, toolTip = "Cool mods minigames kids like."},
                new ButtonInfo { buttonText = "OP Mods", method =() => SettingsMods.OPMods(), isTogglable = false, toolTip = "OP Mods, use carefully."},
                new ButtonInfo { buttonText = "Safety Mods", method =() => SettingsMods.SafetyMods(), isTogglable = false, toolTip = "Safety Mods for the menu."},
                new ButtonInfo { buttonText = "togglable placeholder 3"},
                new ButtonInfo { buttonText = "regular placeholder 4", isTogglable = false},
                new ButtonInfo { buttonText = "togglable placeholder 4"},
                new ButtonInfo { buttonText = "regular placeholder 5", isTogglable = false},
                new ButtonInfo { buttonText = "togglable placeholder 5"},
                new ButtonInfo { buttonText = "regular placeholder 6", isTogglable = false},
                new ButtonInfo { buttonText = "togglable placeholder 6"},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Platforms", method =() => MainMods.plattys(), toolTip = "grips for platforms!"},
                new ButtonInfo { buttonText = "Fly [a]", method =() => MainMods.fly(), toolTip = "hold a to fly!"},
                new ButtonInfo { buttonText = "WASD", method =() => MainMods.wasdddd(), toolTip = "wasd fly for pc!"},
            },

            new ButtonInfo[] { // Cool Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Water Splash Hands", method =() => CoolMods.wathand(), toolTip = "grips for water splash!"},
                new ButtonInfo { buttonText = "Water Splash Aura", method =() => CoolMods.wataura(), toolTip = "water splash aura!"},
                new ButtonInfo { buttonText = "Ride Bug [t]", method =() => CoolMods.bugrideugg(), toolTip = "trigger to ride the bug!"},
            },

            new ButtonInfo[] { // OP Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Bone ESP", method =() => OPMods.bone(), toolTip = "bone esp!"},
                new ButtonInfo { buttonText = "Box ESP", method =() => OPMods.box(), toolTip = "box esp!"},
            },

            new ButtonInfo[] { // Safety Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Fake Oculus Menu [x]", method =() => SafetyMods.oculusfakemenu(), toolTip = "left primary for fake oculus menu!"},
            },
        };
    }
}
