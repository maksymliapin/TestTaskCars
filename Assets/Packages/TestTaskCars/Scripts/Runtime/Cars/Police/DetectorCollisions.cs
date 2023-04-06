using Packages.TestTaskCars.Scripts.Runtime.Barriers;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using Packages.TestTaskCars.Scripts.Runtime.Common;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Police
{
    public class DetectorCollisions : MonoBehaviour
    {
        [SerializeField] private CarMover carMover;
        [SerializeField] private GameObject blast;
        private EventHolder eventHolder;

        [Inject]
        public void Construct(EventHolder eventHolder) =>
            this.eventHolder = eventHolder;

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Block>())
            {
                eventHolder.OneResetPolice();
                carMover.Speed = 0;
                Instantiate(blast,transform.position,Quaternion.Euler(new Vector3(90,0,0)));
                Destroy(gameObject);
            }

            if (other.GetComponent<Car>())
            {
                other.GetComponent<Car>().CarMover.Speed = 0;
                carMover.Speed = 0;
                eventHolder.OneEndGame();
            }
        }
        
    }
}