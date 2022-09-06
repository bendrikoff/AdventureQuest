using UnityEngine;

namespace Switchers
{
    public class AnimationSwitcher : Switcher
    {
        [SerializeField] private Animator _targetAnimator;
    
        private static readonly int SwtichOn = Animator.StringToHash("SwitchOn");
        private static readonly int SwitchOff = Animator.StringToHash("SwitchOff");

        protected override void Switch()
        {
            base.Switch();
            _targetAnimator.SetTrigger(IsSwitchOn ? SwtichOn : SwitchOff);
        }
    }
}
