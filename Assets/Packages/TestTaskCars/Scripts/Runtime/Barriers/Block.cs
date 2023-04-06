using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using Packages.TestTaskCars.Scripts.Runtime.Common;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Barriers
{
    public class Block : MonoBehaviour
    {
        private EventHolder eventHolder;

        [Inject]
        public void Construct(EventHolder eventHolder) =>
            this.eventHolder = eventHolder;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Car>())
            {
                var car = other.gameObject.GetComponent<Car>();
                car.CarMover.Speed = 0;
                eventHolder.OneEndGame();
                Debug.Log("hereBlock");
            }
        }
    }
}