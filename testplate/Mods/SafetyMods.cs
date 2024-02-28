using BepInEx;
using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static StupidTemplate.Mods.Inputs;

namespace StupidTemplate.Mods
{
    internal class SafetyMods
    {
        public static bool E = UnityInput.Current.GetKey(KeyCode.E);
     
        public static void oculusfakemenu()
        {
            if (leftPrimary)
            {
                GorillaLocomotion.Player.Instance.leftControllerTransform.position = GorillaTagger.Instance.bodyCollider.transform.position;
                GorillaLocomotion.Player.Instance.leftControllerTransform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;
                GorillaLocomotion.Player.Instance.rightControllerTransform.position = GorillaTagger.Instance.bodyCollider.transform.position;
                GorillaLocomotion.Player.Instance.rightControllerTransform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;
            }
            if (E)
            {
                GorillaLocomotion.Player.Instance.leftControllerTransform.position = GorillaTagger.Instance.bodyCollider.transform.position;
                GorillaLocomotion.Player.Instance.leftControllerTransform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;
                GorillaLocomotion.Player.Instance.rightControllerTransform.position = GorillaTagger.Instance.bodyCollider.transform.position;
                GorillaLocomotion.Player.Instance.rightControllerTransform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;
            }
        }
        public static void fakeidentity()
        {
            if (UnityEngine.Random.Range(1, 5) == 1)
            {
                
            }
        }
        /* string[] fakename = new string[]
                {
                    "ModderX",
                    "ShibaGT Gold",
                    "Kman Menu",
                    "WM TROLLING MENU",
                    "ShibaGT Dark",
                    "ShibaGT-X v5.5",
                    "bvunt menu",
                    "GorillaTaggingKid Menu",
                    "fart"
                }; */
    }
}
