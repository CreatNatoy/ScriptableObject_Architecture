using UnityEngine;
using Random = UnityEngine.Random;

namespace Runtime_Set.Scripts
{
    public class ChangeColorMaterial : MonoBehaviour
    {
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private ChangeColorMaterialContainer _container;

        private void Start() => _container.Add(this);

        private void OnDestroy() => _container.Remove(this);

        public void ChangeColor()
        {
            Color randomColor = Random.ColorHSV();
            _meshRenderer.material.color = randomColor; 
        }
    }
}
