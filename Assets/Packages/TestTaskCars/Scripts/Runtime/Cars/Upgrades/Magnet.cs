using DG.Tweening;
using Packages.TestTaskCars.Scripts.Runtime.Level;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Upgrades
{
    public class Magnet : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Gold>())
            {
                other.transform.DOMove(transform.position, .1f).SetEase(Ease.InBack);
            }
        }
    }
}