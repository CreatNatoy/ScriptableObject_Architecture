using TMPro;
using UnityEngine;

namespace Delegate_objects.Scripts
{
    [CreateAssetMenu(menuName = "ScriptableObject/SimpleTextDelegateSo", fileName = "SimpleTextDelegateSo")]
    public class SimpleTextDelegateSo : TextDelegateSO
    {
        [SerializeField] private string _text = "Hello!!!";
        [SerializeField] private Color _color = Color.black;
        [SerializeField] private float _fontSize = 24f; 
        
        
        public override void Print(TextMeshProUGUI text)
        {
            text.text = _text;
            text.color = _color;
            text.fontSize = _fontSize; 
        }
    }
}
