﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

namespace Packages.TestTaskCars.Scripts.Runtime.Level
{
    public class RoadFactory
    {
        private List<GameObject> loadRoads = new List<GameObject>();
        private readonly DiContainer container;

        [Inject]
        public RoadFactory(DiContainer container)
        {
            this.container = container;

            LoadRoad();
        }

        private void LoadRoad() =>
            loadRoads = Resources.LoadAll<GameObject>("Prefabs/Roads").ToList();

        public Road CreateRoad(Transform parent)
        {
            var prefab = loadRoads[Random.Range(0, loadRoads.Count)];
            return container.InstantiatePrefab(prefab, parent).GetComponent<Road>();
        }
    }
}