using System.Collections.Generic;
using Packages.TestTaskCars.Scripts.Runtime.Camera;
using Packages.TestTaskCars.Scripts.Runtime.Cars;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class LevelConstructor : MonoBehaviour
    {
        public Car Player { get; private set;}
        public List<Road> Roads;

        [SerializeField] private Transform placePlayer;
        [SerializeField] private CameraController cameraController;
        [SerializeField] private GameObject buttons; 
        private PlayerCarFactory playerCarFactory;

        [Inject]
        public void Construct(PlayerCarFactory playerCarFactory) => 
            this.playerCarFactory = playerCarFactory;

        public void PrepareLevel()
        {
            Player = playerCarFactory.CreatePlayer(placePlayer);
            cameraController.enabled = true;
            buttons.SetActive(true);


        }
    }
}