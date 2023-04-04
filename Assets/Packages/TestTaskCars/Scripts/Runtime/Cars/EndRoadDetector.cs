using System;
using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars
{
    public class EndRoadDetector : MonoBehaviour
    {
        public event Action EndRoad;
        private LevelConstructor levelConstructor;

        [Inject]
        public void Construct(LevelConstructor levelConstructor)
        {
            this.levelConstructor = levelConstructor;
        }

        private void Update()
        {
            var positionLastRoad = levelConstructor.Roads[levelConstructor.Roads.Count - 1].transform.position;
            if (transform.position.z > positionLastRoad.z)
            {
                EndRoad?.Invoke();
            }
        }
    }
}