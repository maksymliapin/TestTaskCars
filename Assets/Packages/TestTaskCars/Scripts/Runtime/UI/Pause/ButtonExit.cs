using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI.Pause
{
    public class ButtonExit : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Application.Quit();
            Time.timeScale = 1;
        }
    }
}