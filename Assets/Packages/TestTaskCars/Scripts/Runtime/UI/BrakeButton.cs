using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class BrakeButton : MonoBehaviour
    {
        [SerializeField] private LevelConstructor levelConstructor;
        
        private void OnMouseDrag() => 
            levelConstructor.Player.CarMover.BrakeDown();
    }
}