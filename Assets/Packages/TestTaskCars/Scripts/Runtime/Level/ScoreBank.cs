using Packages.TestTaskCars.Scripts.Runtime.Common;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class ScoreBank
    {
        private float score;
        private readonly EventHolder eventHolder;

        [Inject]
        public ScoreBank(EventHolder eventHolder) => 
            this.eventHolder = eventHolder;

        public void Add(float value)
        {
            score += value;
            eventHolder.OneChangeScore(score);
            var bestScore = PlayerPrefs.GetFloat("BestScore", 0);
            if (bestScore < score)
            {
                PlayerPrefs.SetFloat("BestScore",score);
            }
        }
        public float GetScoreCounter() => 
            score;
    }
}