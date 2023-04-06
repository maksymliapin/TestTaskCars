using Packages.TestTaskCars.Scripts.Runtime.Common;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class ScoreBank
    {
        private float score;
        private EventHolder eventHolder;

        [Inject]
        public ScoreBank(EventHolder eventHolder)
        {
            this.eventHolder = eventHolder;
        }
        
        public void Add(float value)
        {
            score += value;
            eventHolder.OneChangeScore(score);
        }
    }
}