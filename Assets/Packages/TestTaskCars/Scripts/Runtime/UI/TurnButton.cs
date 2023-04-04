using Packages.TestTaskCars.Scripts.Runtime.Cars;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class TurnButton : MonoBehaviour
    {
        [SerializeField] private bool Isleft;
        [SerializeField] private CarMover car;
        [SerializeField] private Transform steeringWheel;

        private void OnMouseDrag()
        {
            if (Isleft)
            {
                car.TurnLeft();
                
            }
            else
            {
                car.TurnRight();
            }
        }
    }
}