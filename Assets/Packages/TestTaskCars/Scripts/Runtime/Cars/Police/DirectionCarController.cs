using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Police
{
    public class DirectionCarController : MonoBehaviour
    {
        [SerializeField] private CarMover carMover;
        [SerializeField] private BoxCollider colliderPoliceCar;
        private LevelConstructor levelConstructor;

        [Inject]
        public void Construct(LevelConstructor levelConstructor) =>
            this.levelConstructor = levelConstructor;

        private void Update()
        {
            if (transform.position.z > levelConstructor.Player.transform.position.z - 10f)
            {
                colliderPoliceCar.enabled = true;
                if (levelConstructor.Player.transform.position.x > transform.position.x)
                {
                    carMover.TurnRight();
                }

                if (levelConstructor.Player.transform.position.x < transform.position.x)
                {
                    carMover.TurnLeft();
                }
            }
            else
            {
                if (colliderPoliceCar.enabled )
                {
                    colliderPoliceCar.enabled = false;
                }
            }
        }
    }
}