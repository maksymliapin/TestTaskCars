using Packages.TestTaskCars.Scripts.Runtime.Cars;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class GasButton : MonoBehaviour
    {
        [SerializeField] private CarMover car;
        
        private void OnMouseDrag()
        {
            car.Gas();
        }
    }
}