using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Police
{
    public class PoliceCarFactory
    {
        private readonly DiContainer container;

        [Inject]
        public PoliceCarFactory(DiContainer container) => 
            this.container = container;

        private GameObject LoadPoliceCar() => 
            Resources.Load<GameObject>("Prefabs/Cars/Police/PoliceCar");

        public PoliceCar CreatePoliceCar(Transform parent) => 
            container.InstantiatePrefab(LoadPoliceCar(),parent).GetComponent<PoliceCar>();
    }
}