﻿using Packages.TestTaskCars.Scripts.Runtime.Common;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class UpgradeProgressBarController : MonoBehaviour
    {
        [SerializeField] private GameObject shieldProgressBar;
        [SerializeField] private GameObject magnetProgressBar;
        [SerializeField] private GameObject nitroProgressBar;
        

        [Inject]
        public void Construct(EventHolder eventHolder)
        {
            eventHolder.ActivateShied += ActivateShieldBar;
            eventHolder.DeactivateShied += DeactivateShieldBar;
            eventHolder.ActivateMagnet += ActivateMagnetBar;
            eventHolder.DeactivateMagnet += DeactivateMagnetBar;
            eventHolder.ActivateNitro += ActivateMagnetBar;
            eventHolder.DeactivateNitro += DeactivateMagnetBar;
        }

        private void ActivateShieldBar() => 
            shieldProgressBar.SetActive(true);
        
        private void DeactivateShieldBar() => 
            shieldProgressBar.SetActive(false);
        
        private void ActivateMagnetBar() => 
            magnetProgressBar.SetActive(true);
        
        private void DeactivateMagnetBar() => 
            magnetProgressBar.SetActive(false);
        
        private void ActivateNitroBar() => 
            nitroProgressBar.SetActive(true);
        
        private void DeactivateNitroBar() => 
            nitroProgressBar.SetActive(false);
    }
}