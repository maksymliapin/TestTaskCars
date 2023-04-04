using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class GasButton : MonoBehaviour
    {
        [SerializeField] private LevelConstructor levelConstructor;
        
        private void OnMouseDrag() => 
            levelConstructor.Player.CarMover.Gas();
    }
}