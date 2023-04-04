using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Packages.TestTaskCars.Scripts.Runtime.Cars;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class TurnButton : MonoBehaviour
    {
        [SerializeField] private bool Isleft;
        [SerializeField] private CarMover car;
        [SerializeField] private Transform steeringWheel;
        private TweenerCore<Quaternion,Vector3,QuaternionOptions> tween;

        private void OnMouseDrag()
        {
            if (Isleft)
            {
                car.TurnLeft();
            }
            else
            {
                car.TurnRight();
            }
        }

        private void OnMouseDown()
        {
           tween = steeringWheel.DOLocalRotate(
                Isleft ? new Vector3(0, 0, 60) : new Vector3(0, 0, -60), 1);
        }

        private void OnMouseUp()
        {
            tween.Kill();
            steeringWheel.DOLocalRotate(Vector3.zero, .5f);
        }
    }
}