using System.Collections;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars
{
    public class SpeedPenaltyController : MonoBehaviour
    {
        [SerializeField] private CarMover car;
        private bool isUsed;

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
            car.Speed -= 5f;
            car.MaxSpeed = car.Speed;
            yield return new WaitForSeconds(time);
            car.Speed += 5f;
            car.MaxSpeed = 15;
            isUsed = false;
        }
    }
}