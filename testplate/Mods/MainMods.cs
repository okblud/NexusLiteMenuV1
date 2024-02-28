using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class MainMods
    {
        public static GameObject platl;
        public static GameObject platr;


        private static Vector3 platformOffset = new Vector3(0, 0, 0);
        private static int startX;
        private static float subThingy;

        public static void wasdddd()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0.067f, 0f);

            bool W = UnityInput.Current.GetKey(KeyCode.W);
            bool A = UnityInput.Current.GetKey(KeyCode.A);
            bool S = UnityInput.Current.GetKey(KeyCode.S);
            bool D = UnityInput.Current.GetKey(KeyCode.D);
            bool Space = UnityInput.Current.GetKey(KeyCode.Space);
            bool Ctrl = UnityInput.Current.GetKey(KeyCode.LeftControl);

            if (W)
            {
                GorillaTagger.Instance.rigidbody.transform.position += GorillaTagger.Instance.rigidbody.transform.forward * Time.deltaTime * 12;
            }

            if (S)
            {
                GorillaTagger.Instance.rigidbody.transform.position += GorillaTagger.Instance.rigidbody.transform.forward * Time.deltaTime * -12;
            }

            if (Mouse.current.rightButton.isPressed)
            {
                Vector3 Euler = GorillaTagger.Instance.rigidbody.transform.rotation.eulerAngles;
                if (startX < 0)
                {
                    startX = (int)Euler.y;
                    subThingy = Mouse.current.position.ReadValue().x / UnityEngine.Screen.width;
                }
                Euler = new Vector3(Euler.x, startX + ((((Mouse.current.position.ReadValue().x / UnityEngine.Screen.width) - subThingy) * 360) * 1.33f), Euler.z);
                GorillaTagger.Instance.rigidbody.transform.rotation = Quaternion.Euler(Euler);
            }
            else
            {
                startX = -1;
            }

            if (A)
            {
                GorillaTagger.Instance.rigidbody.transform.position += GorillaTagger.Instance.rigidbody.transform.right * Time.deltaTime * -12;
            }

            if (D)
            {
                GorillaTagger.Instance.rigidbody.transform.position += GorillaTagger.Instance.rigidbody.transform.right * Time.deltaTime * 12;
            }

            if (Space)
            {
                GorillaTagger.Instance.rigidbody.transform.position += GorillaTagger.Instance.rigidbody.transform.up * Time.deltaTime * 12;
            }

            if (Ctrl)
            {
                GorillaTagger.Instance.rigidbody.transform.position += GorillaTagger.Instance.rigidbody.transform.up * Time.deltaTime * -12;
            }
        }
        public static void fly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * 25;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        public static void plattys()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (platl == null)
                {
                    platl = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platl.transform.localScale = new Vector3(0.4f, 0.025f, 0.3f);
                    platl.transform.position = GorillaTagger.Instance.leftHandTransform.position + platformOffset;
                    platl.transform.rotation = Quaternion.Euler(0, GorillaTagger.Instance.leftHandTransform.rotation.eulerAngles.y, 0);
                    platl.GetComponent<Renderer>().material.color = Color.cyan;
                }
            }
            else
            {
                if (platl != null)
                {
                    UnityEngine.Object.Destroy(platl);
                    platl = null;
                }
            }

            if (ControllerInputPoller.instance.rightGrab)
            {
                if (platr == null)
                {
                    platr = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platr.transform.localScale = new Vector3(0.4f, 0.025f, 0.3f);
                    platr.transform.position = GorillaTagger.Instance.rightHandTransform.position + platformOffset;
                    platr.transform.rotation = Quaternion.Euler(0, GorillaTagger.Instance.rightHandTransform.rotation.eulerAngles.y, 0);
                    platr.GetComponent<Renderer>().material.color = Color.cyan;
                }
            }
            else
            {
                if (platr != null)
                {
                    UnityEngine.Object.Destroy(platr);
                    platr = null;
                }
            }
        }
    }
}
