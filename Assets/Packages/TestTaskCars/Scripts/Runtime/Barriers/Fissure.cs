using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Barriers
{
    public class Fissure : MonoBehaviour
    {
        private PathData pathData;

        [Inject]
        public void Construct(PathData pathData) =>
            this.pathData = pathData;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Car>())
            {
                var car = other.gameObject.GetComponent<Car>();
                if (car.ShieldController.IsActiveShield == false)
                {
                    car.CarMover.Speed -= pathData.PenaltyFissure;
                    car.HealthController.TakeDamage(pathData.DamageFissure);
                }
            }
        }
    }
}