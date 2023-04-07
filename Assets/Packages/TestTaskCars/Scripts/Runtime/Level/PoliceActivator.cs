using System.Collections;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Police;
using Packages.TestTaskCars.Scripts.Runtime.Common;
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
        private EventHolder eventHolder;

        private const int Offset = 10;

        [Inject]
        public void Construct(PoliceCarFactory policeCarFactory, PathData pathData, EventHolder eventHolder)
        {
            this.policeCarFactory = policeCarFactory;
            this.pathData = pathData;
            this.eventHolder = eventHolder;
        }

        private void Awake()
        {
            eventHolder.ResetPolice += ActivatePolice;

            ActivatePolice();
        }

        private void ActivatePolice() =>
            StartCoroutine(StartPolice());

        private IEnumerator StartPolice()
        {
            yield return new WaitForSeconds(pathData.TimeOutPolice);
            var police = policeCarFactory.CreatePoliceCar(parentPlayer);

            var policePosition = police.transform.position;
            policePosition = new Vector3(policePosition.x, policePosition.y,
                levelConstructor.Player.transform.position.z - Offset);
            police.transform.position = policePosition;

            police.CarMover.Speed = levelConstructor.Player.CarMover.Speed + pathData.SpeedDifferencePolice;
        }
    }
}