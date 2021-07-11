using UnityEngine;
using Game.Salvers;
using System;
using Game.Shapes;

namespace Game.ServiceStations
{
    [System.Serializable]
    public class SalverStand : MonoBehaviour, ICanNotDestroyable
    {
        [SerializeField] private Transform _standingPoint;
        [SerializeField] private Salver _template;

        private Salver _salver;

        public event Action<Salver> NeededDestroy;
        public event Action<ShapeAsset> SpawnNeeded;

        public Transform StandingPoint => _standingPoint;
        public Salver Salver => _salver;

        private void Start()
        {
            TrySpawnSalver();
        }

        public void PutNewObject(Salver salver)
        {
            NeededDestroy?.Invoke(_salver);
            _salver = salver;
            _salver.transform.position = _standingPoint.position;
        }

        public void SpawnShapeInSalver(ShapeAsset shapeAsset)
        {
            TrySpawnSalver();
            _salver.Add(shapeAsset);
        }

        private void TrySpawnSalver()
        {
            if (SalverAvailable() == false)
                SpawnSalver();
        }

        private void SpawnSalver()
        {
            _salver = Instantiate(_template, _standingPoint);
        }

        private bool SalverAvailable()
        {
            return _salver != null;
        }
    }
}
