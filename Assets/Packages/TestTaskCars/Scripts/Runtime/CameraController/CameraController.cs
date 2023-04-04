using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.CameraController
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private GameObject playerCar;
        private Camera mainCamera;
        private const float Offset = 4;

        private void Awake() =>
            mainCamera = Camera.main;

        private void Update()
        {
            var positionCamera = mainCamera.transform.position;
            positionCamera = new Vector3(positionCamera.x, positionCamera.y, playerCar.transform.position.z + Offset);

            mainCamera.transform.position = positionCamera;
        }
    }
}