using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Oculus")]
    [Tooltip("Sends an Event when a Gear or Go Button is pressed.")]
    public class GetGearGoButton : FsmStateAction
    {

        [Tooltip("Select the button to be pressed.")]
        public setButton button;

        [Tooltip("Select how the button type should send the event.")]
        public setButtonType buttonType;

        public enum setButton
        {
            One,
            Two,
            Back,
            PrimaryTouchpad,
            PrimaryIndexTrigger,
            Up,
            Down,
            Left,
            Right,
        };

        public enum setButtonType
        {
            getButton,
            getButtonDown,
            getButtonUp,
        };


        [Tooltip("Event to send if the button is pressed.")]
        public FsmEvent sendEvent;

        [Tooltip("Set to True if the button is pressed.")]
        [UIHint(UIHint.Variable)]
        public FsmBool storeResult;
        private OVRInput.Controller controllerInput;

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
            
            switch (button)
            {
                case setButton.One:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.One, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.One, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.One, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
                case setButton.Two:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.Two, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.Two, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.Two, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }                    
                    break;
                case setButton.Back:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstick, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
                case setButton.PrimaryTouchpad:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
                case setButton.PrimaryIndexTrigger:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
                case setButton.Up:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
                case setButton.Down:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
                case setButton.Left:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
                case setButton.Right:
                    switch (buttonType)
                    {
                        case setButtonType.getButton:
                            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
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
                            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                        case setButtonType.getButtonUp:
                            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, controllerInput))
                            {
                                storeResult.Value = true;
                                Fsm.Event(sendEvent);
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
