using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Extendable_Enums.Scripts
{
    public class GameControllerUi : MonoBehaviour
    {
        [Header("Components Ui")]
        [SerializeField] private Button _rockButton;
        [SerializeField] private Button _paperButton;
        [SerializeField] private Button _scissorsButton;
        [SerializeField] private TextMeshProUGUI _textResult; 
        [Header("Components So")] 
        [SerializeField] private GameItemSO _rockSo;
        [SerializeField] private GameItemSO _paperSo;
        [SerializeField] private GameItemSO _scissorsSo;

        private EnemyAI _enemyAI;

        private string _messageWin = "You win. For a new game, please make your selection again.";
        private string _messageLost = "You Lost. For a new game, please make your selection again.";

        private void Start()
        {
            _enemyAI = new EnemyAI(new GameItemSO[] {_rockSo, _paperSo, _scissorsSo} );

            UnityAction<bool> resultHandler = HandlerResultPick;
            
            _rockButton.onClick.AddListener(() => resultHandler(_enemyAI.IsWinn(_rockSo)));
            _paperButton.onClick.AddListener(() => resultHandler(_enemyAI.IsWinn(_paperSo)));
            _scissorsButton.onClick.AddListener(() => resultHandler(_enemyAI.IsWinn(_scissorsSo)));
        }

        private void HandlerResultPick(bool isWin) => 
            _textResult.text = isWin ? _messageWin : _messageLost;
    }
}
