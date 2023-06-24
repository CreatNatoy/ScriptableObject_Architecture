using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ServiceLocator.Scripts
{
    public class ChangeColor : MonoBehaviour
    {
        [SerializeField] private ServiceLocatorSo _service; 
        [SerializeField] private MeshRenderer _meshRenderer;

        private void Awake() => _service.Register(this);

        private void OnDestroy() => _service.Remove<ChangeColor>();

        public void Change()
        {
            Color randomColor = Random.ColorHSV();
            _meshRenderer.material.color = randomColor; 
        }
    }
}
