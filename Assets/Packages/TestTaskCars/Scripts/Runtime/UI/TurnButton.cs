using System;
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
        [SerializeField] private SpriteRenderer carRenderer;
        [SerializeField] private Transform leftBord;
        [SerializeField] private Transform rightBord;
        private TweenerCore<Quaternion, Vector3, QuaternionOptions> tween;
        private float carSizeX;

        private void Awake() => 
            carSizeX = carRenderer.bounds.size.x/2;

        private void OnMouseDrag()
        {
            if (Isleft)
            {
                var offset = leftBord.position.x + carSizeX;
                if (car.transform.position.x > offset)
                {
                    car.TurnLeft();
                    carRenderer.transform.DOLocalRotate(new Vector3(90, 0, 5), .5f);
                }
            }
            else
            {
                var offset = rightBord.position.x - carSizeX;
                if (car.transform.position.x <offset)
                {
                    car.TurnRight();
                    carRenderer.transform.DOLocalRotate(new Vector3(90, 0, -5), .5f);
                }
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