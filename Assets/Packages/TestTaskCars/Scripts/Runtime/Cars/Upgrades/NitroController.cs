using System.Collections;
using Packages.TestTaskCars.Scripts.Runtime.Common;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades
{
    public class NitroController : MonoBehaviour
    {
        [SerializeField] private GameObject nitro;
        [SerializeField] private CarMover carMover;
        [SerializeField] private UpgradeChecker upgradeChecker;
        private PathData pathData;
        private EventHolder eventHolder;

        [Inject]
        public void Construct(PathData pathData, EventHolder eventHolder)
        {
            this.pathData = pathData;
            this.eventHolder = eventHolder;
        }

        public void ActivateNitro() =>
            StartCoroutine(StartNitro());

        private IEnumerator StartNitro()
        {
            upgradeChecker.IsUsedUpgrade = true;
            eventHolder.OneActivateNitro();
            carMover.MaxSpeed = pathData.MaxSpeedCar + 5;
            carMover.Speed = carMover.MaxSpeed;
            nitro.SetActive(true);
            for (int i = 0; i < pathData.TimeBonus; i++)
            {
                yield return new WaitForSeconds(1);
                eventHolder.OneChangeNitro(pathData.TimeBonus - i);
            }

            carMover.MaxSpeed = pathData.MaxSpeedCar - 5;
            carMover.Speed -= 5;
            nitro.SetActive(false);
            eventHolder.OneDeactivateNitro();
            upgradeChecker.IsUsedUpgrade = false;
        }
    }
    
}