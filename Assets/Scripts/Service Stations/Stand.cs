using UnityEngine;
using Game.Salvers;
using System;
using Game.Spawners;
using Game.Shapes;

namespace Game.ServiceStations
{
    [System.Serializable]
    public class Stand : ICanNotDestroyable, IReportNeedSpawnable
    {
        [SerializeField] private Transform _standingPoint;

        private Salver _salver;

        public event Action<Salver> NeededDestroy;
        public event Action<ShapeAsset> SpawnNeeded;

        public Transform StandingPoint => _standingPoint;
        public Salver Salver => _salver;

        public void PutNewObject(Salver salver)
        {
            NeededDestroy?.Invoke(_salver);
            _salver = salver;
            _salver.transform.position = _standingPoint.position;
        }
    }
}
