using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Common
{
    public class LevelBootstrap : MonoBehaviour
    {
        [SerializeField] private LevelConstructor levelConstructor;

        private void Awake() => 
            StartGame();

        private void StartGame()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;
            
            levelConstructor.PrepareLevel();
        }
    }
}