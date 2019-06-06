using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Oculus")]
    [Tooltip("Checks if the headset was recentered.")]
    public class GetGearGoWasRecentered : FsmStateAction
    {
        [Tooltip("Event to send if the headset has been recentered.")]
        public FsmEvent sendEvent;

        [Tooltip("Set to True if the headset has been recentered.")]
        [UIHint(UIHint.Variable)]
        public FsmBool storeResult;

        public override void Reset()
        {
            sendEvent = null;
            storeResult = null;
        }

        public override void OnUpdate()
        {
            if (OVRInput.GetControllerWasRecentered())
            {
                storeResult.Value = true;
                Fsm.Event(sendEvent);
            }
            else
            {
                storeResult.Value = false;
            }
        }
    }
}
