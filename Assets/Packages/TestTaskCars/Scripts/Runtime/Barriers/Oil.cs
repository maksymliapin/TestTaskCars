using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Barriers
{
    public class Oil : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Car>())
            {
                var car = other.gameObject.GetComponent<Car>();
                if (car.ShieldController.IsActiveShield == false)
                {
                    car.SpeedPenaltyController.StartPenalty(10);
                    Debug.Log("hereOil");
                }
            }
        }
    }
}