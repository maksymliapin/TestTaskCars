using System;

namespace Packages.TestTaskCars.Scripts.Runtime.Common
{
    public class EventHolder
    {
        public event Action EndGame;
        public event Action EndRoad;

        public void OneEndGame() => 
            EndGame?.Invoke();
      
    }
}