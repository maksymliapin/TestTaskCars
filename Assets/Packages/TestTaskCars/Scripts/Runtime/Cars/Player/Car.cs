using Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Player
{
    public class Car: MonoBehaviour
    {
        public CarMover CarMover;
        public SpriteRenderer CarRenderer;
        public EndRoadDetector EndRoadDetector;
        public SpeedPenaltyController SpeedPenaltyController;
        public HealthController HealthController;
        public ShieldController ShieldController;
        public NitroController NitroController;
        public MagnetController MagnetController;
    }
}