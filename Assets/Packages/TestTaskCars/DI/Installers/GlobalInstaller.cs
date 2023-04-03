using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.DI.Installers
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("here");
        }
    }
}
