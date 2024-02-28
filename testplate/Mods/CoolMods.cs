using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using UnityEngine;
using static StupidTemplate.Mods.Inputs;
using static StupidTemplate.Mods.Variables;
using static StupidTemplate.Menu.Main;
using static Pathfinding.Util.RetainedGizmos;
using System.Runtime.InteropServices;

namespace StupidTemplate.Mods
{
    internal class CoolMods
    {
        private static Vector3 startpos;
        private static Vector3 charvel;

        public static void waterbend()
        {
            if (otherdelay < Time.time)
            {
                otherdelay = Time.time + 0.05f;
                if (leftGrab && rightGrab)
                {
                    Vector3 vector = Vector3.Lerp(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.leftHandTransform.position, 0.5f);
                    GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
                    {
                        vector,
                        Quaternion.identity,
                        Vector3.Distance(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.leftHandTransform.position),
                        Vector3.Distance(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.leftHandTransform.position),
                        false,
                        true
                    });
                    ClearRPCS();
                }
            }
        }
        public static void wathand()
        {
            if (rightGrab)
            {
                if (Time.time > splashDel)
                {
                    GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", RpcTarget.All, new object[]
                    {
                        GorillaTagger.Instance.rightHandTransform.position,
                        GorillaTagger.Instance.rightHandTransform.rotation,
                        4f,
                        100f,
                        true,
                        false
                    });
                    ClearRPCS();
                    splashDel = Time.time + 0.1f;
                }
            }
            if (leftGrab)
            {
                if (Time.time > splashDel)
                {
                    GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", RpcTarget.All, new object[]
                    {
                        GorillaTagger.Instance.leftHandTransform.position,
                        GorillaTagger.Instance.leftHandTransform.rotation,
                        4f,
                        100f,
                        true,
                        false
                    });
                    ClearRPCS();
                    splashDel = Time.time + 0.1f;
                }
            }
        }

        public static void wataura()
        {
            if (Time.time > splashDel)
            {
                GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", RpcTarget.All, new object[]
                {
                    GorillaTagger.Instance.offlineVRRig.transform.position + new Vector3(UnityEngine.Random.Range(-0.360f,0.360f),UnityEngine.Random.Range(-0.360f,0.360f),UnityEngine.Random.Range(-0.360f,0.360f)),
                    GorillaTagger.Instance.offlineVRRig.transform.rotation,
                    4f,
                    100f,
                    true,
                    false
                });
                ClearRPCS();
                splashDel = Time.time + 0.1f;
            }
        }
        public static void bugrideugg()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
            {
                GorillaTagger.Instance.rigidbody.transform.position = GameObject.Find("Floating Bug Holdable").transform.position + new Vector3(0f, 0.5f, 0f);
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        public static void thrustgun()
        {
            if (rightGrab)
            {
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position - GorillaLocomotion.Player.Instance.rightControllerTransform.up, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var Ray);
                GameObject NewPointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                NewPointer.GetComponent<Renderer>().material.color = Color.green;
                NewPointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                NewPointer.transform.position = Ray.point;
                UnityEngine.Object.Destroy(NewPointer.GetComponent<BoxCollider>());
                UnityEngine.Object.Destroy(NewPointer.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(NewPointer.GetComponent<Collider>());
                UnityEngine.Object.Destroy(NewPointer, Time.deltaTime);
                if (isCopying && target != null)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    {
                        GorillaTagger.Instance.offlineVRRig.transform.position = target.transform.position + (target.transform.forward * (0.2f + (Mathf.Sin(Time.frameCount / 8f) * 0.1f)));
                        GorillaTagger.Instance.myVRRig.transform.position = target.transform.position + (target.transform.forward * (0.2f + (Mathf.Sin(Time.frameCount / 8f) * 0.1f)));

                        GorillaTagger.Instance.offlineVRRig.transform.rotation = target.transform.rotation;
                        GorillaTagger.Instance.myVRRig.transform.rotation = target.transform.rotation;

                        GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.transform.position = (target.transform.position + target.transform.right * -0.2f) + target.transform.up * -0.4f;
                        GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.transform.position = (target.transform.position + target.transform.right * 0.2f) + target.transform.up * -0.4f;

                        GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.transform.rotation = target.transform.rotation;
                        GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.transform.rotation = target.transform.rotation;

                        GorillaTagger.Instance.offlineVRRig.head.rigTarget.transform.rotation = target.transform.rotation;
                    }

                    GorillaTagger.Instance.offlineVRRig.head.rigTarget.transform.rotation = target.transform.rotation;

                    if ((Time.frameCount % 45) == 0)
                    {
                        GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", RpcTarget.All, new object[]
                        {
                        GorillaTagger.Instance.offlineVRRig.transform.position + new Vector3(0f, -0.4f, 0f),
                        GorillaTagger.Instance.offlineVRRig.transform.rotation,
                        4f,
                        100f,
                        true,
                        false
                        });
                        ClearRPCS();
                    }

                    GameObject l = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(l.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(l.GetComponent<SphereCollider>());

                    l.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    l.transform.position = GorillaTagger.Instance.leftHandTransform.position;

                    GameObject r = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(r.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(r.GetComponent<SphereCollider>());

                    r.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    r.transform.position = GorillaTagger.Instance.rightHandTransform.position;

                    l.GetComponent<Renderer>().material.color = Color.blue;
                    r.GetComponent<Renderer>().material.color = Color.blue;

                    UnityEngine.Object.Destroy(l, Time.deltaTime);
                    UnityEngine.Object.Destroy(r, Time.deltaTime);
                }
                if (rightTrigger)
                {
                    VRRig possibly = Ray.collider.GetComponentInParent<VRRig>();
                    if (possibly && possibly != GorillaTagger.Instance.offlineVRRig)
                    {
                        isCopying = true;
                        target = possibly;
                    }
                }
            }
            else
            {
                if (isCopying)
                {
                    isCopying = false;
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }
            }
        }
        public static void riderandom()
        {
            if (rightTrigger)
            {
                foreach (VRRig rig in GorillaParent.instance.vrrigs)
                {
                    GorillaTagger.Instance.rigidbody.transform.position = rig.transform.position + new Vector3(0f, 0.4f, 0f);
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
        }
    }
}
