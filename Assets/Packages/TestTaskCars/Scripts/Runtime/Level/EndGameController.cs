using System;
using Packages.TestTaskCars.Scripts.Runtime.Common;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class EndGameController: MonoBehaviour
    {
        [SerializeField] private GameObject endGameMenu;
        [SerializeField] private GameObject gameInterface;
        private EventHolder eventHolder;

        [Inject]
        public void Construct(EventHolder eventHolder) => 
            eventHolder.EndGame += CompleteGame;

        private void CompleteGame()
        {
            endGameMenu.SetActive(true);
            gameInterface.SetActive(false);
            Time.timeScale = 0;
        }
    }
}