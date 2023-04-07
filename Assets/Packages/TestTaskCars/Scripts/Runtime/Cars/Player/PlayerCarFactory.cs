using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Player
{
    public class PlayerCarFactory
    {
        private readonly DiContainer container;
        private const string Path = "Prefabs/Cars/Player/PlayerCar";

        [Inject]
        public PlayerCarFactory(DiContainer container) => 
            this.container = container;

        private GameObject LoadPlayer() => 
            Resources.Load<GameObject>(Path);

        public Car CreatePlayer(Transform parent) => 
            container.InstantiatePrefab(LoadPlayer(),parent).GetComponent<Car>();
    }
}