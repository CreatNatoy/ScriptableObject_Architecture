using TMPro;
using UnityEngine;

namespace Observer.Scripts
{
    public class HandlerStatusAnimationText : MonoBehaviour
    {
        [Header("Components Ui")] 
        [SerializeField] private TextMeshProUGUI _textStatus;
        [Header("Components So")]
        [SerializeField] private VoidEventChannelSO _startEventChannel;
        [SerializeField] private VoidEventChannelSO _endEventChannel;

        private readonly string _textPlayAnimation = "Play Animation";
        private readonly string _textStopAnimation = "Stop Animation";

        private void Start()
        {
            _startEventChannel.OnEventRaised += SetTextPlayAnimation;
            _endEventChannel.OnEventRaised += SetTextEndAnimation;
        }

        private void OnDestroy()
        {
            _startEventChannel.OnEventRaised -= SetTextPlayAnimation;
            _endEventChannel.OnEventRaised -= SetTextEndAnimation;
        }

        private void SetTextPlayAnimation() => _textStatus.text = _textPlayAnimation;
        
        private void SetTextEndAnimation() => _textStatus.text = _textStopAnimation;
    }
}