using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI.Pause
{
    public class ClosePause : MonoBehaviour
    {
        [SerializeField] private GameObject menuPause;
        [SerializeField] private GameObject gameInterface;

        private void OnMouseDown()
        {
            menuPause.SetActive(false);
            gameInterface.SetActive(true);
            Time.timeScale = 1;
        }
    }
}