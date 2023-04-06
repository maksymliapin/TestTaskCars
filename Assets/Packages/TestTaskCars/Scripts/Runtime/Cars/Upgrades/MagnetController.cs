using System.Collections;
using Packages.TestTaskCars.Scripts.Runtime.Common;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades
{
    public class MagnetController : MonoBehaviour
    {
        [SerializeField] private GameObject magnet;
        private PathData pathData;
        private EventHolder eventHolder;

        [Inject]
        public void Construct(PathData pathData, EventHolder eventHolder)
        {
            this.pathData = pathData;
            this.eventHolder = eventHolder;
        }

        public void ActivateMagnet() =>
            StartCoroutine(StartNitro());

        private IEnumerator StartNitro()
        {
            eventHolder.OneActivateMagnet();
            magnet.SetActive(true);

            for (var i = 0; i < pathData.TimeBonus; i++)
            {
                yield return new WaitForSeconds(1);
                eventHolder.OneChangeMagnet(pathData.TimeBonus - i);
            }

            magnet.SetActive(false);
            eventHolder.OneDeactivateMagnet();
        }
    }
}