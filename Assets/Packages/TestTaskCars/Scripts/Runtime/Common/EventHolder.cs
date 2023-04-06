using System;

namespace Packages.TestTaskCars.Scripts.Runtime.Common
{
    public class EventHolder
    {
        public event Action EndGame;
        public event Action ResetPolice;
        public event Action<float> ChangeHealth;
        public event Action<float> ChangeShield;
        public event Action<float> ChangeMagnet;
        public event Action<float> ChangeNitro;
        public event Action ActivateShied;
        public event Action DeactivateShied; 
        public event Action ActivateMagnet;
        public event Action DeactivateMagnet; 
        public event Action ActivateNitro;
        public event Action DeactivateNitro;
        public event Action<float> ChangeScore;

        public void OneEndGame() =>
            EndGame?.Invoke();

        public void OneResetPolice() =>
            ResetPolice?.Invoke();

        public void OneChangeHealth(float value) =>
            ChangeHealth?.Invoke(value);
        public void OneChangeScore(float value) =>
            ChangeScore?.Invoke(value);
        public void OneChangeShield(float value) =>
            ChangeShield?.Invoke(value);
        public void OneChangeMagnet(float value) =>
            ChangeMagnet?.Invoke(value);
        public void OneChangeNitro(float value) =>
            ChangeNitro?.Invoke(value);
        
        public void OneActivateShied() =>
            ActivateShied?.Invoke();
        public void OneDeactivateShied() =>
            DeactivateShied?.Invoke();
        public void OneActivateMagnet() =>
            ActivateMagnet?.Invoke();
        public void OneDeactivateMagnet() =>
            DeactivateMagnet?.Invoke();
        public void OneActivateNitro() =>
            ActivateNitro?.Invoke();
        public void OneDeactivateNitro() =>
            DeactivateNitro?.Invoke();
        
        
    }
}