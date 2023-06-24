using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Runtime_Set.Scripts
{
    public class RandomSetColor : MonoBehaviour
    {
        [SerializeField] private Button _button; 
        [SerializeField] private ChangeColorMaterialContainer _container;

        private void Start()
        {
            _button.onClick.AddListener(SetColor);
        }

        private void SetColor()
        {
            var items = _container.Items;
            int randomIndex = Random.Range(0, items.Count);
            items[randomIndex].ChangeColor();
        }
    }
}