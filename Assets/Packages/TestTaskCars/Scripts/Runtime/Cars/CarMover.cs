using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars
{
    public class CarMover : MonoBehaviour
    {
        public float Speed;
        public float MaxSpeed;

        private void Update() =>
            Forward();

        public void Gas()
        {
            if (Speed < MaxSpeed)
            {
                Speed += .05f;
            }
        }

        public void BrakeDown()
        {
            if (Speed >= 0)
            {
                Speed -= .1f;
            }
        }

        public void TurnRight() =>
            transform.position += transform.right * Speed * Time.deltaTime;

        public void TurnLeft() =>
            transform.position -= transform.right * Speed * Time.deltaTime;

        private void Forward()
        {
            if (Speed > 0)
            {
                transform.position += transform.forward * Speed * Time.deltaTime;
            }
        }
    }
}