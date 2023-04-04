using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars
{
    public class CarMover : MonoBehaviour
    {
        public float speed;
        
        private void Awake() => 
            Gas();

        private void Update() => 
            Forward();

        public void Gas() => 
            speed += 1;

        public void BrakeDown()
        {
            if (speed != 0)
            {
                speed += 1;
            }
        }
        
        public void TurnRight() => 
            transform.position += transform.right * speed * Time.deltaTime;

        public void TurnLeft() => 
            transform.position -= transform.right * speed * Time.deltaTime;

        private void Forward() => 
            transform.position += transform.forward * speed * Time.deltaTime;
    }
}