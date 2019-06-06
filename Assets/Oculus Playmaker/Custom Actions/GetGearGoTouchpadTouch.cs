using UnityEngine;


namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Oculus")]
    [Tooltip("Gets the value of the Gear Go Touchpad based on touch.")]
    public class GetGearGoTouchpadTouch : FsmStateAction
    {
        [Tooltip("Select how the button type should send the event.")]
        public setButtonType buttonType;

        [Tooltip("Event to send if the button is pressed.")]
        public FsmEvent sendEvent;

        [Tooltip("Set to True if the button is pressed.")]
        [UIHint(UIHint.Variable)]
        public FsmBool storeResult;

        private OVRInput.Controller controllerInput;

        public enum setButtonType
        {
            getButton,
            getButtonDown,
            getButtonUp,
        };


        public override void Reset()
        {
            sendEvent = null;
            storeResult = null;
        }
        public override void OnEnter()
        {
            controllerInput = OVRInput.Controller.RTrackedRemote;
        }

        public override void OnUpdate()
        {
            switch (buttonType)
            {
                case setButtonType.getButton:
                    if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad, controllerInput))
                    {
                        storeResult.Value = true;
                        Fsm.Event(sendEvent);
                    }
                    else
                    {
                        storeResult.Value = false;
                    }
                    break;
                case setButtonType.getButtonDown:
                    if (OVRInput.GetDown(OVRInput.Touch.PrimaryTouchpad, controllerInput))
                    {
                        storeResult.Value = true;
                        Fsm.Event(sendEvent);
                    }
                    break;
                case setButtonType.getButtonUp:
                    if (OVRInput.GetUp(OVRInput.Touch.PrimaryTouchpad, controllerInput))
                    {
                        storeResult.Value = true;
                        Fsm.Event(sendEvent);
                    }
                    break;
            }
        }
    }
}