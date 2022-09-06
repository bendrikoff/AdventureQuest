using UnityEngine;

namespace Switchers
{
    public abstract class Switcher : MonoBehaviour,Interactable
    {
        
        [SerializeField] private Animator _swticherAnimator;
        
        private static readonly int SwtichOn = Animator.StringToHash("SwitchOn");
        private static readonly int SwitchOff = Animator.StringToHash("SwitchOff");
        
        protected bool IsSwitchOn;

        void Start()
        { 
            IsSwitchOn = false;
        }

        protected virtual void Switch()
        {
            IsSwitchOn = !IsSwitchOn;
            _swticherAnimator.SetTrigger(IsSwitchOn ? SwtichOn : SwitchOff);
        }

        public void OnInteract()
        {
            Switch();
        }
    }
}
