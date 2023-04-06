using System;

namespace Packages.TestTaskCars.Scripts.Runtime.Common
{
    public class EventHolder
    {
        public event Action EndGame;
        public event Action ResetPolice;
        public event Action<float> ChangeHealth;
        public event Action<float> ChangeScore;

        public void OneEndGame() =>
            EndGame?.Invoke();

        public void OneResetPolice() =>
            ResetPolice?.Invoke();

        public void OneChangeHealth(float value) =>
            ChangeHealth?.Invoke(value);
        public void OneChangeScore(float value) =>
            ChangeScore?.Invoke(value);
    }
}