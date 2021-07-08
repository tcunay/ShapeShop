using UnityEngine;
using Game.Salvers;
using System;

namespace Game.ServiceStations
{
    [System.Serializable]
    public class Stand : ICanNotDestroyable
    {
        [SerializeField] private Transform _standingPoint;

        private Salver _salver;

        public event Action<Salver> NeededDestroy;

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
