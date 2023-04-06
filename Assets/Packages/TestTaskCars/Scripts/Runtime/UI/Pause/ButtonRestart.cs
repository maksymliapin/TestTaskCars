using UnityEngine;
using UnityEngine.SceneManagement;

namespace Packages.TestTaskCars.Scripts.Runtime.UI.Pause
{
    public class ButtonRestart : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("LevelScene");
        }
    }
}