using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Delegate_objects.Scripts
{
    public class ControllerUi : MonoBehaviour
    {
        [Header("Components Ui")]
        [SerializeField] private Button[] _buttonsVariant;
        [SerializeField] private TextMeshProUGUI _text;
        [Header("Components SO")]
        [SerializeField] private TextDelegateSO[] _textsVariant;

        private void Start()
        {
            for (int i = 0; i < _buttonsVariant.Length; i++)
            {
                int index = i; 
                _buttonsVariant[index].onClick.AddListener(() => _textsVariant[index].Print(_text));
            }
        }
    }
}
