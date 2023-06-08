using Sirenix.OdinInspector;
using UnityEngine;

namespace Configuration.Scripts
{
    [CreateAssetMenu(fileName = "ParametersSo", menuName = "ScriptableObject/ParametersSo")]
    [InlineEditor]
    public class ParametersSo : ScriptableObject
    {
        [SerializeField] private int _maxHealth;
        [SerializeField] private int _speed;
        [SerializeField] private int _damage;
        [SerializeField] private int _defence;
    }
}
