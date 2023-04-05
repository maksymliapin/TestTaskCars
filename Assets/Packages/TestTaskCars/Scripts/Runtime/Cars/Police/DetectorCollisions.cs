using Packages.TestTaskCars.Scripts.Runtime.Barriers;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Police
{
    public class DetectorCollisions : MonoBehaviour
    {
        [SerializeField] private CarMover carMover;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Block>())
            {
                carMover.Speed = 0;
                Destroy(gameObject);
            }
            if (other.GetComponent<Car>())
            {
                other.GetComponent<Car>().CarMover.Speed = 0;
                carMover.Speed = 0;
            }
        }
        
    }
}