using System;

namespace Packages.TestTaskCars.Scripts.Runtime.Common
{
    public class EventHolder
    {
        public event Action EndGame;
        public event Action ResetPolice;

        public void OneEndGame() =>
            EndGame?.Invoke();
        public void OneResetPolice() =>
            ResetPolice?.Invoke();
    }
}