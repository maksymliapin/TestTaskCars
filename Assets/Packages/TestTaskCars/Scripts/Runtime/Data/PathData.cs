using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Data
{
    [CreateAssetMenu(fileName = nameof(PathData), menuName = "TestTaskCars/GameData/" + nameof(PathData))]
    public class PathData : ScriptableObject
    {
        public float MaxSpeedCar;
        public float DefaultHealth;
        public float HeardHealth;
        public float PenaltySpeedOil;
        public float PenaltyFissure;
        public float DamageFissure;
        public float TimeOutPolice;
        public float SpeedDifferencePolice;
        public float GoldValue;
    }
}