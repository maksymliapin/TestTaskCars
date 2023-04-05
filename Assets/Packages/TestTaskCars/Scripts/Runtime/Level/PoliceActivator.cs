using System.Collections;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Police;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class PoliceActivator : MonoBehaviour
    {
        [SerializeField] private LevelConstructor levelConstructor;
        [SerializeField] private Transform parentPlayer;
        private PoliceCarFactory policeCarFactory;
        private PathData pathData;

        [Inject]
        public void Construct(PoliceCarFactory policeCarFactory, PathData pathData)
        {
            this.policeCarFactory = policeCarFactory;
            this.pathData = pathData;
        }

        private void Awake()
        {
            StartCoroutine(ActivatePolice());
        }

        private IEnumerator ActivatePolice()
        {
            yield return new WaitForSeconds(pathData.TimeOutPolice);
            Debug.Log("here");
            var police = policeCarFactory.CreatePoliceCar(parentPlayer);

            var policePosition = police.transform.position;
            policePosition = new Vector3(policePosition.x, policePosition.y,
                levelConstructor.Player.transform.position.z - 8);
            
            police.transform.position = policePosition;
            police.CarMover.Speed = pathData.SpeedPolice;
        }
    }
}