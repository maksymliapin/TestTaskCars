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

        private void OnDestroy() => 
            Unsubscribe();

        public void Subscribe() => 
            levelConstructor.Player.EndRoadDetector.EndRoad += UpdateMap;
        public void Unsubscribe() => 
            levelConstructor.Player.EndRoadDetector.EndRoad -= UpdateMap;

        private void UpdateMap()
        {
            CreatNextRoad();
            DestroyLastRoad();
        }

        private void DestroyLastRoad()
        {
            var lastRoad = levelConstructor.Roads[0];
            levelConstructor.Roads.Remove(lastRoad);
            Destroy(lastRoad.gameObject);
        }

        private void CreatNextRoad()
        {
            var lastRound = levelConstructor.Roads[levelConstructor.Roads.Count - 1];
            var lastRoundPosition = lastRound.transform.position;
            var offset = lastRound.GetComponent<SpriteRenderer>().bounds.size.z;
            var placeRound = new Vector3(lastRoundPosition.x, lastRoundPosition.y, lastRoundPosition.z + offset);

            var road = roadFactory.CreateRoad(parentRoads);
            levelConstructor.Roads.Add(road);
            road.transform.position = placeRound;
        }
    }
}