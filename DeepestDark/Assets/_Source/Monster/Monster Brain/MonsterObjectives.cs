using MovingObjectSystem.WaypointsProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MonsterBrainSystem
{
    [Serializable]
    public class MonsterObjectives
    {
        [SerializeField] private AMBWaypointsProvider waypointsProvider;
        
        [field: Space]
        [field: SerializeField] public bool IsActive { get; private set; }

        public List<Vector3> Route { get => waypointsProvider.Waypoints.ToList(); }
    }
}
