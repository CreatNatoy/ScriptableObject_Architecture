using UnityEngine;

namespace Extendable_Enums.Scripts
{
    [CreateAssetMenu(menuName = "ScriptableObject/GameItemSO", fileName = "GameItemSO")]
    public class GameItemSO : ScriptableObject
    {
        [SerializeField] private GameItemSO _weakness;

        public GameItemSO Weakness => _weakness;

        public bool IsWinner(GameItemSO other) => other.Weakness == this; 
    }
}
