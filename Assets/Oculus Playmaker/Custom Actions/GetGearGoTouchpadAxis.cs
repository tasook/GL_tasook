using UnityEngine;


namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Oculus")]
    [Tooltip("Gets the value of Gear or Go Touchpad Axis.")]
    public class GetGearGoTouchpadAxis : FsmStateAction
    {

        [Tooltip("Axis values are in the range -1 to 1. Use the multiplier to set a larger range.")]
        public FsmFloat multiplier = 1;

        [UIHint(UIHint.Variable)]
        [Tooltip("Store the result in a Vector 2 variable.")]
        public FsmVector2 storeVector2;

        [UIHint(UIHint.Variable)]
        [Tooltip("Store the result in a float variable.")]
        public FsmFloat storeX;

        [UIHint(UIHint.Variable)]
        [Tooltip("Store the result in a float variable.")]
        public FsmFloat storeY;

        private OVRInput.Controller controllerInput;

        public override void Reset()
        {
            multiplier = 1f;
            storeVector2 = null;
            storeX = null;
            storeY = null;
        }
        public override void OnEnter()
        {
            controllerInput = OVRInput.Controller.RTrackedRemote;
        }

        public override void OnUpdate()
        {
            var axisValue = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, controllerInput);
            axisValue *= multiplier.Value;

            storeVector2.Value = axisValue;

            storeX.Value = axisValue.x;

            storeY.Value = axisValue.y;

        }
    }
}