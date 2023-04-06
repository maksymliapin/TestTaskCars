using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class ShieldBonus : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Car>())
            {
                other.gameObject.GetComponent<Car>().ShieldController.ActivateShield();
                Destroy(gameObject);
            }
        }
    }
}