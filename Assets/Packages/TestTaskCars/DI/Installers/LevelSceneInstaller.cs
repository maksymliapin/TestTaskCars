using Packages.TestTaskCars.Scripts.Runtime.Cars;
using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.DI.Installers
{
    public class LevelSceneInstaller : MonoInstaller
    {
        [SerializeField] private LevelConstructor levelConstructor;
        
        public override void InstallBindings()
        {
            Container.BindInstance(levelConstructor).AsSingle();
            Container.Bind<RoadFactory>().AsSingle();
            Container.Bind<PlayerCarFactory>().AsSingle();
        }
    }
}
