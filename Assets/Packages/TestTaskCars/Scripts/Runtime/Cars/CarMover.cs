using Packages.TestTaskCars.Scripts.Runtime.Data;
using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars
{
    public class CarMover : MonoBehaviour, ICarMover
    {
        public float MaxSpeed;
        public float Speed { get; set; }
        
        [SerializeField] private SpriteRenderer carRenderer;
        
        private float carSizeX;
        private LevelConstructor levelConstructor;

        [Inject]
        public void Construct(PathData pathData, LevelConstructor levelConstructor)
        {
            this.levelConstructor = levelConstructor;

            MaxSpeed = pathData.MaxSpeedCar;
            carSizeX = carRenderer.bounds.size.x / 2;
        }

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

        public void TurnRight()
        {
            var offset = levelConstructor.Roads[levelConstructor.Roads.Count - 1].RightBord.position.x - carSizeX;
            if (transform.position.x < offset)
            {
                transform.position += transform.right * Speed * Time.deltaTime;
            }
        }

        public void TurnLeft()
        {
            var offset = levelConstructor.Roads[levelConstructor.Roads.Count - 1].LeftBord.position.x + carSizeX;
            if (transform.position.x > offset)
            {
                transform.position -= transform.right * Speed * Time.deltaTime;
            }
        }

        private void Forward()
        {
            if (Speed > 0)
            {
                transform.position += transform.forward * Speed * Time.deltaTime;
            }
        }
    }
}