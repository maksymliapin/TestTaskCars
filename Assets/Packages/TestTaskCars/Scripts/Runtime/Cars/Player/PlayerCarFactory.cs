using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Player
{
    public class PlayerCarFactory
    {
        private readonly DiContainer container;

        [Inject]
        public PlayerCarFactory(DiContainer container) => 
            this.container = container;

        private GameObject LoadPlayer() => 
            Resources.Load<GameObject>("Prefabs/Cars/Player/PlayerCar");

        public Car CreatePlayer(Transform parent) => 
            container.InstantiatePrefab(LoadPlayer(),parent).GetComponent<Car>();
    }
}