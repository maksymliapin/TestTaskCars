using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars
{
    public class Car: MonoBehaviour
    {
        public CarMover CarMover;
        public SpriteRenderer CarRenderer;
        public EndRoadDetector EndRoadDetector;
        public SpeedPenaltyController SpeedPenaltyController;
    }
}