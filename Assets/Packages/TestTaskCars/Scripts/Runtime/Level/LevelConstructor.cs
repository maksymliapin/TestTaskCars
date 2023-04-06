using System.Collections.Generic;
using Packages.TestTaskCars.Scripts.Runtime.Camera;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class LevelConstructor : MonoBehaviour
    {
        public Car Player { get; private set; }
        public List<Road> Roads;

        [SerializeField] private Transform parentPlayer;
        [SerializeField] private CameraController cameraController;
        [SerializeField] private GameObject gameInterface;
        [SerializeField] private MapGenerator mapGenerator;
        private PlayerCarFactory playerCarFactory;

        [Inject]
        public void Construct(PlayerCarFactory playerCarFactory) => 
            this.playerCarFactory = playerCarFactory;

        public void PrepareLevel()
        {
            CreatPlayerCar();
            PrepareCamera();
            
            gameInterface.SetActive(true);
            mapGenerator.Subscribe();
            
        }

        private void PrepareCamera() => 
            cameraController.enabled = true;

        private void CreatPlayerCar()
        {
            Player = playerCarFactory.CreatePlayer(parentPlayer);
            Player.transform.position = parentPlayer.position;
        }
    }
}