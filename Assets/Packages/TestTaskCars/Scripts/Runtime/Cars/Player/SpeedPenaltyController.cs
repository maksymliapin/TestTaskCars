using System.Collections;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Player
{
    public class SpeedPenaltyController : MonoBehaviour
    {
        [SerializeField] private CarMover car;
        private bool isUsed;
        private PathData pathData;

        [Inject]
        public void Construct(PathData pathData) => 
            this.pathData = pathData;

        public void StartPenalty(float time)
        {
            if (isUsed == false)
            {
                StartCoroutine(SlowDown(time));
            }
        }

        private IEnumerator SlowDown(float time)
        {
            isUsed = true;
            car.Speed -= pathData.PenaltySpeedOil;
            car.MaxSpeed = car.Speed;
            yield return new WaitForSeconds(time);
            car.Speed += pathData.PenaltySpeedOil;
            car.MaxSpeed = pathData.MaxSpeedCar;
            isUsed = false;
        }
    }
}