using System.Collections.Generic;
using Packages.TestTaskCars.Scripts.Runtime.Camera;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Police;
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
        [SerializeField] private GameObject buttons;
        [SerializeField] private MapGenerator mapGenerator;
        private PlayerCarFactory playerCarFactory;
        private PoliceCarFactory policeCarFactory;

        [Inject]
        public void Construct(PlayerCarFactory playerCarFactory, PoliceCarFactory policeCarFactory)
        {
            this.playerCarFactory = playerCarFactory;
            this.policeCarFactory = policeCarFactory;
        }

        public void PrepareLevel()
        {
            Player = playerCarFactory.CreatePlayer(parentPlayer);
            Player.transform.position = parentPlayer.position;
            cameraController.enabled = true;
            buttons.SetActive(true);
            mapGenerator.Subscribe();
            var police = policeCarFactory.CreatePoliceCar(parentPlayer);
            police.transform.position = new Vector3(police.transform.position.x, Player.transform.position.y,
                Player.transform.position.z - 6);
            police.CarMover.Speed = 3f;
        }
    }
}