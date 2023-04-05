using Packages.TestTaskCars.Scripts.Runtime.Cars;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Barriers
{
    public class Fissure : MonoBehaviour
    {
         private void OnTriggerEnter(Collider other)
                {
                    if (other.gameObject.GetComponent<Car>())
                    {
                        var car = other.gameObject.GetComponent<Car>();
                        car.CarMover.Speed -= 3;

                    }
                }
    }
}