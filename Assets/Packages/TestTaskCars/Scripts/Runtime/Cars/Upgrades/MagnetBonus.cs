using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades
{
    public class MagnetBonus : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Car>())
            {
                var car =other.gameObject.GetComponent<Car>();
                if (car.UpgradeChecker.IsUsedUpgrade == false)
                {
                    car.MagnetController.ActivateMagnet();
                    Destroy(gameObject);
                }
            }
        }
    }
}