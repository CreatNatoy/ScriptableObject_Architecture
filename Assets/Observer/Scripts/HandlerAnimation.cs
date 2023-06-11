using UnityEngine;
using UnityEngine.UI;

namespace Observer.Scripts
{
    public class HandlerAnimation : MonoBehaviour
    {
        [Header("Components Ui")]
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _endButton;
        [Header("Components So")]
        [SerializeField] private VoidEventChannelSO _startEventChannel;
        [SerializeField] private VoidEventChannelSO _endEventChannel;
        [Space] 
        [SerializeField] private Animator _animator;

        private void Start()
        {
            _startEventChannel.OnEventRaised += StartAnimation;
            _endEventChannel.OnEventRaised += StopAnimation;
            _startButton.onClick.AddListener(_startEventChannel.RaiseEvent);
            _endButton.onClick.AddListener(_endEventChannel.RaiseEvent);
        }

        private void OnDestroy()
        {
            _startEventChannel.OnEventRaised -= StartAnimation;
            _endEventChannel.OnEventRaised -= StopAnimation;
            _startButton.onClick.RemoveListener(_startEventChannel.RaiseEvent);
            _endButton.onClick.RemoveListener(_endEventChannel.RaiseEvent);
        }

        private void StartAnimation() => _animator.enabled = true;
        
        private void StopAnimation() => _animator.enabled = false;
    }
}
