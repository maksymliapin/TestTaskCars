using Packages.TestTaskCars.Scripts.Runtime.Common;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class ShieldProgressBar : MonoBehaviour
    {
        [SerializeField] private Image image;
        private PathData pathData;

        [Inject]
        public void Construct(EventHolder eventHolder, PathData pathData)
        {
            this.pathData = pathData;
            eventHolder.ChangeShield += SetValue;
        }

        private void SetValue(float value) =>
            image.fillAmount = value / pathData.TimeShield;
    }
}