using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades
{
    public class Gold : MonoBehaviour
    {
        private ScoreBank scoreBank;
        private PathData pathData;

        [Inject]
        public void Construct(ScoreBank scoreBank,PathData pathData)
        {
            this.scoreBank = scoreBank;
            this.pathData = pathData;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Car>())
            {
                scoreBank.Add(pathData.GoldValue);
                Destroy(gameObject);
            }
        }
    }
}