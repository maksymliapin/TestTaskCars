using Packages.TestTaskCars.Scripts.Runtime.Cars.Player;
using Packages.TestTaskCars.Scripts.Runtime.Cars.Police;
using Packages.TestTaskCars.Scripts.Runtime.Common;
using Packages.TestTaskCars.Scripts.Runtime.Data;
using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.DI.Installers
{
    public class LevelSceneInstaller : MonoInstaller
    {
        [SerializeField] private LevelConstructor levelConstructor;
        [SerializeField] private PathData pathData;

        public override void InstallBindings()
        {
            Container.BindInstance(levelConstructor).AsSingle();
            Container.BindInstance(pathData).AsSingle();
            
            Container.Bind<EventHolder>().AsSingle();
            Container.Bind<RoadFactory>().AsSingle();
            Container.Bind<PoliceCarFactory>().AsSingle();
            Container.Bind<PlayerCarFactory>().AsSingle();
            Container.Bind<ScoreBank>().AsSingle();

        }
    }
}
