using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.UI
{
    public class TurnButton : MonoBehaviour
    {
        [SerializeField] private bool Isleft;
        [SerializeField] private LevelConstructor levelConstructor;
        [SerializeField] private Transform steeringWheel;
        private TweenerCore<Quaternion, Vector3, QuaternionOptions> tween;
        private SpriteRenderer carRenderer;

        private void Awake() =>
            carRenderer = levelConstructor.Player.CarRenderer;

        private void OnMouseDrag()
        {
            if (Isleft)
            {
                levelConstructor.Player.CarMover.TurnLeft();
                carRenderer.transform.DOLocalRotate(new Vector3(90, 0, 5), .5f);
            }
            else
            {
                levelConstructor.Player.CarMover.TurnRight();
                carRenderer.transform.DOLocalRotate(new Vector3(90, 0, -5), .5f);
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
            carRenderer.transform.DOLocalRotate(new Vector3(90, 0, 0), .5f);
        }
    }
}