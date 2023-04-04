using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars
{
    public class PlayerCarFactory
    {
        private readonly DiContainer container;

        [Inject]
        public PlayerCarFactory(DiContainer container) => 
            this.container = container;

        private GameObject LoadPlayer() => 
            Resources.Load<GameObject>("Prefabs/Cars/Player/PlayerCar");

        public Car CreatePlayer() => 
            container.InstantiatePrefab(LoadPlayer()).GetComponent<Car>();
    }
}