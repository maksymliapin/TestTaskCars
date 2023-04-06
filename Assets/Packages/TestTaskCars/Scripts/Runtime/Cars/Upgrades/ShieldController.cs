using System.Collections;
using Packages.TestTaskCars.Scripts.Runtime.Common;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades
{
    public class ShieldController : MonoBehaviour
    {
        public bool IsActiveShield { get; private set; }

        [SerializeField] private GameObject shield;
        private PathData pathData;
        private EventHolder eventHolder;

        [Inject]
        public void Construct(PathData pathData,EventHolder eventHolder)
        {
            this.pathData = pathData;
            this.eventHolder = eventHolder;
        }

        public void ActivateShield() => 
            StartCoroutine(StartShield());

        private IEnumerator StartShield()
        {
            eventHolder.OneActivateShied();
            IsActiveShield = true;
            shield.SetActive(true);
            for (int i = 0; i < pathData.TimeBonus; i++)
            {
                yield return new WaitForSeconds(1);
                eventHolder.OneChangeShield(pathData.TimeBonus -i);
            }
            shield.SetActive(false);
            IsActiveShield = false;
            eventHolder.OneDeactivateShied();
        }
    }
}