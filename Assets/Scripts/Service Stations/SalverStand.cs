using UnityEngine;
using Game.Salvers;

namespace Game.ServiceStations
{
    [System.Serializable]
    public class SalverStand
    {
        [SerializeField] private Transform _standPoint;

        private ShapesSalver _salver;

        public void PutSalver(ShapesSalver salver)
        {
            _salver = salver;
            _salver.transform.position = _standPoint.position;
        }

        public ShapesSalver GiveSalver()
        {
            return _salver;
        }

    }
}
