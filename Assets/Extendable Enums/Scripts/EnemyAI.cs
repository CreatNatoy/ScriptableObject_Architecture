using UnityEngine;

namespace Extendable_Enums.Scripts
{
    public class EnemyAI
    {
        private readonly GameItemSO[] _gameItemsSo;

        public EnemyAI(GameItemSO[] gameItemsSo)
        {
            _gameItemsSo = gameItemsSo; 
        }

        public bool IsWinn(GameItemSO gameItem)
        {
            var randomIndex = Random.Range(0, _gameItemsSo.Length); 
            var randomItem = _gameItemsSo[randomIndex];

            return randomItem.IsWinner(gameItem); 
        }
    }
}