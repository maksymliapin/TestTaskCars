using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.UI.EndGameMenu
{
    public class ScoreMenuSetter: MonoBehaviour
    {
        [SerializeField] private Text score;
        [SerializeField] private Text bestScore;
        private ScoreBank scoreBank;

        [Inject]
        public void Construct(ScoreBank scoreBank) => 
            this.scoreBank = scoreBank;

        private void OnEnable()
        {
            bestScore.text = PlayerPrefs.GetFloat("BestScore", 0).ToString();
            score.text = scoreBank.GetScoreCounter().ToString();
        }
    }
}