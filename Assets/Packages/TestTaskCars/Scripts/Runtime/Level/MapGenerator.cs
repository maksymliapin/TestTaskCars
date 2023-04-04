using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class MapGenerator : MonoBehaviour
    {
        [SerializeField] private Transform parentRoads;
        [SerializeField] private LevelConstructor levelConstructor;
        private RoadFactory roadFactory;

        [Inject]
        public void Construct(RoadFactory roadFactory) =>
            this.roadFactory = roadFactory;

        public void UpdateMap()
        {
            CreatNextRoad();
            DestroyLastRoad();
        }

        private void DestroyLastRoad()
        {
        }

        private void CreatNextRoad()
        {
            var lastRound = levelConstructor.Roads[levelConstructor.Roads.Count - 1];
            var lastRoundPosition = lastRound.transform.position;
            var offset = lastRound.GetComponent<SpriteRenderer>().bounds.size.z;
            var placeRound = new Vector3(lastRoundPosition.x, lastRoundPosition.y, lastRoundPosition.z + offset);
            
            levelConstructor.Roads.Add(roadFactory.CreateRoad(parentRoads, placeRound));
        }
    }
}