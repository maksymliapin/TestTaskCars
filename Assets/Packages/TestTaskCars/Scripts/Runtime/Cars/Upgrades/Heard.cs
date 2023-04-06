using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades
{
    public class Heard : MonoBehaviour
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
                car.HealthController.AddHealth(pathData.HeardHealth);
                Destroy(gameObject);
            }
        }
    }
}