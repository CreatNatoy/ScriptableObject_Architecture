using UnityEngine;
using UnityEngine.Events;

namespace Observer.Scripts
{
    [CreateAssetMenu(menuName = "ScriptableObject/Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        public event UnityAction OnEventRaised;

        public void RaiseEvent() => OnEventRaised?.Invoke(); 
    }
}
