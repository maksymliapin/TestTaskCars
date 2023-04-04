using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private LevelConstructor levelConstructor;
        private UnityEngine.Camera mainCamera;
        private const float Offset = 4;

        private void Awake() =>
            mainCamera = UnityEngine.Camera.main;

        private void Update()
        {
            var positionCamera = mainCamera.transform.position;
            positionCamera = new Vector3(positionCamera.x, positionCamera.y,
                levelConstructor.Player.transform.position.z + Offset);

            mainCamera.transform.position = positionCamera;
        }
    }
}