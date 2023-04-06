using System.Collections;
using UnityEngine;

namespace Packages.TestTaskCars.Scripts.Runtime.Cars.Police
{
    public class Blast : MonoBehaviour
    {
        private void Awake() => 
            StartCoroutine(StartBlast());

        private IEnumerator StartBlast()
        {
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }
    }
}