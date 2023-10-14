using Strategy.Strategies;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy
{
    public class AttackPerformer : MonoBehaviour
    {
        [SerializeField] private Button fireButton;
        [SerializeField] private Button iceButton;
        [SerializeField] private Button lightningButton;

        private Character _character;
        private IAttackStrategy _currentStrategy;

        private void Start()
        {
            _character = new Character();
            
            fireButton.onClick.AddListener(() => SelectStrategy(new FireAttack()));
            iceButton.onClick.AddListener(() => SelectStrategy(new IceAttack()));
            lightningButton.onClick.AddListener(() => SelectStrategy(new LightningAttack()));
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _character.PerformAttack();
            }
        }

        private void SelectStrategy(IAttackStrategy strategy)
        {
            _currentStrategy = strategy;
            _character.SetStrategy(_currentStrategy);
            
            HighlightButton(strategy.GetType());
        }

        private void HighlightButton(System.Type strategyType)
        {
            fireButton.GetComponent<Image>().color = Color.white;
            iceButton.GetComponent<Image>().color = Color.white;
            lightningButton.GetComponent<Image>().color = Color.white;
            
            if (strategyType == typeof(FireAttack))
            {
                fireButton.GetComponent<Image>().color = Color.red;
            }
            else if (strategyType == typeof(IceAttack))
            {
                iceButton.GetComponent<Image>().color = Color.blue;
            }
            else if (strategyType == typeof(LightningAttack))
            {
                lightningButton.GetComponent<Image>().color = Color.yellow;
            }
        }
    }
}