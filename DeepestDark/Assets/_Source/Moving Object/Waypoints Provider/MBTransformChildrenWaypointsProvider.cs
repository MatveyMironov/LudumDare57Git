using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace MovingObjectSystem.WaypointsProvider
{
    public class MBTransformChildrenWaypointsProvider : AMBWaypointsProvider
    {
        private readonly List<Vector3> _waypoints = new();

        public override ReadOnlyCollection<Vector3> Waypoints { get { return _waypoints.AsReadOnly(); } }

        private void Start()
        {
            Transform[] transforms = GetComponentsInChildren<Transform>();
            foreach (Transform transform in transforms)
                _waypoints.Add(transform.position);
        }
    }
}
