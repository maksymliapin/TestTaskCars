using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI.Pause
{
    public class ButtonPause : MonoBehaviour
    {
        [SerializeField] private GameObject menuPause;
        [SerializeField] private GameObject gameInterface;

        private void OnMouseDown()
        {
            menuPause.SetActive(true);
            gameInterface.SetActive(false);
            Time.timeScale = 0;
        }
    }
}