using Packages.TestTaskCars.Scripts.Runtime.Cars;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class BrakeButton : MonoBehaviour
    {
        [SerializeField] private CarMover car;
        
        private void OnMouseDrag() => 
            car.BrakeDown();
    }
}