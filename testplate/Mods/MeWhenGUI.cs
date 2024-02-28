using BepInEx;
using GorillaNetworking;
using Photon.Pun;
using StupidTemplate.Classes;
using StupidTemplate.Menu;
using StupidTemplate.Patches;
using System;
using System.Drawing;
using UnityEngine;

namespace iiMenu.UI
{
    [BepInPlugin("org.cool.uyauaa", "nexus lite gui <3", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        private string inputText = "nexus [period to close]";

        private string r = "0";

        private string g = "128";

        private string b = "142";

        public static bool isOpen = true;

        public static bool lastCondition = false;

        public static bool modbox;

        private void OnGUI()
        {
            bool isKeyboardCondition = UnityInput.Current.GetKey(KeyCode.Period);

            if (isKeyboardCondition && !lastCondition)
            {
                isOpen = !isOpen;
            }
            lastCondition = isKeyboardCondition;

            if (isOpen)
            {
                GUI.color = UnityEngine.Color.white;
                GUI.backgroundColor = UnityEngine.Color.black;

                GUI.Box(new Rect(Screen.width - 250, 10, 240, 120), "", GUI.skin.box);

                string roomText = "Not connected to room";
                try
                {
                    if (PhotonNetwork.InRoom)
                    {
                        roomText = "Connected to room " + PhotonNetwork.CurrentRoom.Name;
                    }
                }
                catch { } // shitty ass code
                GUI.Label(new Rect(0, Screen.height - 25, Screen.width, 40), roomText);

                inputText = GUI.TextField(new Rect(Screen.width - 200, 20, 180, 20), inputText);
                // inputText = inputText.ToUpper(); i dont need this

                r = GUI.TextField(new Rect(Screen.width - 240, 20, 30, 20), r);

                g = GUI.TextField(new Rect(Screen.width - 240, 50, 30, 20), g);

                b = GUI.TextField(new Rect(Screen.width - 240, 80, 30, 20), b);

                if (GUI.Button(new Rect(Screen.width - 200, 50, 85, 30), "Name"))
                {
                    try
                    {
                        GorillaComputer.instance.currentName = inputText;
                        PhotonNetwork.LocalPlayer.NickName = inputText;
                        GorillaComputer.instance.offlineVRRigNametagText.text = inputText;
                        GorillaComputer.instance.savedName = inputText;
                        PlayerPrefs.SetString("playerName", inputText);
                        PlayerPrefs.Save();
                    }
                    catch
                    {
                        UnityEngine.Debug.Log("lemming is yet to fix me");
                    }
                }
                if (GUI.Button(new Rect(Screen.width - 105, 50, 85, 30), "Color"))
                {
                    UnityEngine.Color color = new Color32(byte.Parse(r), byte.Parse(g), byte.Parse(b), 255);

                    PlayerPrefs.SetFloat("redValue", Mathf.Clamp(color.r, 0f, 1f));
                    PlayerPrefs.SetFloat("greenValue", Mathf.Clamp(color.g, 0f, 1f));
                    PlayerPrefs.SetFloat("blueValue", Mathf.Clamp(color.b, 0f, 1f));

                    //GorillaTagger.Instance.offlineVRRig.mainSkin.material.color = color;
                    GorillaTagger.Instance.UpdateColor(color.r, color.g, color.b);
                    PlayerPrefs.Save();

                    GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", RpcTarget.All, new object[] { color.r, color.g, color.b, false });
                }
                modbox = GUI.Toggle(new Rect(Screen.width - 200, 90, 85, 30), modbox, "Mods");
                if (modbox)
                {
                    GUI.Box(new Rect(Screen.width - 500, 10, 240, 120), "Mods", GUI.skin.box);
                    if (GUI.Button(new Rect(Screen.width - 450, 50, 85, 30), "Test"))
                    {

                    }
                }
            }
        }
    }
}