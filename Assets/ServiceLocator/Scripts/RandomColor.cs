using UnityEngine;
using UnityEngine.UI;

namespace ServiceLocator.Scripts
{
    public class RandomColor : MonoBehaviour
    {
        [SerializeField] private ServiceLocatorSo _service;
        [SerializeField] private Button _button;

        private void Start()
        {
            var changeColor = _service.Get<ChangeColor>(); 
            _button.onClick.AddListener(changeColor.Change);
        }
    }
}