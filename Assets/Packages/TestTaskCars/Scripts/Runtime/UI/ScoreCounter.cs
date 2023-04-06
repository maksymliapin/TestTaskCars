using Packages.TestTaskCars.Scripts.Runtime.Common;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private Text text;

        [Inject]
        public void Construct(EventHolder eventHolder) => 
            eventHolder.ChangeScore+= SetValue;

        private void SetValue(float value) => 
            text.text = value.ToString();
    }
}