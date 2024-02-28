using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Inputs
    {
        public static bool rightGrab = ControllerInputPoller.instance.rightGrab;
        public static bool leftGrab = ControllerInputPoller.instance.leftGrab;
        public static bool rightPrimary = ControllerInputPoller.instance.rightControllerPrimaryButton;
        public static bool rightSecondary = ControllerInputPoller.instance.rightControllerSecondaryButton;
        public static bool leftPrimary = ControllerInputPoller.instance.leftControllerPrimaryButton;
        public static bool leftSecondary = ControllerInputPoller.instance.leftControllerSecondaryButton;
        public static bool rightTrigger = (ControllerInputPoller.instance.rightControllerIndexFloat == 0.5f);
        public static bool leftTrigger = (ControllerInputPoller.instance.leftControllerIndexFloat == 0.5f);
    }
}
