using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Police
{
    public class PoliceCarFactory
    {
        private readonly DiContainer container;
        private const string Path = "Prefabs/Cars/Police/PoliceCar";

        [Inject]
        public PoliceCarFactory(DiContainer container) => 
            this.container = container;

        private GameObject LoadPoliceCar() => 
            Resources.Load<GameObject>(Path);

        public PoliceCar CreatePoliceCar(Transform parent) => 
            container.InstantiatePrefab(LoadPoliceCar(),parent).GetComponent<PoliceCar>();
    }
}