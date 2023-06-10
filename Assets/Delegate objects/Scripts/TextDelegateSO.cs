using TMPro;
using UnityEngine;

namespace Delegate_objects.Scripts
{
    public abstract class TextDelegateSO : ScriptableObject
    {
        public abstract void Print(TextMeshProUGUI text); 
    }
}
