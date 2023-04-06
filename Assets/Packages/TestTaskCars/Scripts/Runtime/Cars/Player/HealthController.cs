using Packages.TestTaskCars.Scripts.Runtime.Common;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Player
{
    public class HealthController : MonoBehaviour
    {
        private float health;
        private EventHolder eventHolder;
        private PathData pathData;

        [Inject]
        public void Construct(EventHolder eventHolder, PathData pathData)
        {
            this.eventHolder = eventHolder;
            this.pathData = pathData;
            health = pathData.DefaultHealth;
        }

        public void TakeDamage(float value)
        {
            health -= value;
            eventHolder.OneChangeHealth(health);
            if (health <= 0)
            {
                eventHolder.OneEndGame();
            }
        }

        public void AddHealth(float value)
        {
            if (health < pathData.DefaultHealth)
            {
                health += value;
                eventHolder.OneChangeHealth(health);
            }
        }
    }
}