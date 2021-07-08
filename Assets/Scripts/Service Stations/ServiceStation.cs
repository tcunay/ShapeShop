using System.Collections.Generic;
using Game.Salvers;
using UnityEngine;

namespace Game.ServiceStations
{
    public class ServiceStation : MonoBehaviour
    {
        [SerializeField] private Conveyor _conveyor;
        [SerializeField] private Stand _startSalverStand;
        [SerializeField] private Salver _template;

        private List<Salver> _salvers = new List<Salver>();

        private void OnEnable()
        {
            _startSalverStand.NeededDestroy += DestroySalver;
            _conveyor.NeededDestroy += DestroySalver;
        }

        private void OnDisable()
        {
            _startSalverStand.NeededDestroy -= DestroySalver;
            _conveyor.NeededDestroy -= DestroySalver;
        }

        public void SpawnSalver()
        {
            PutInStand(Instantiate(_template));
        }

        private void PutInStand(Salver salver)
        {
            _startSalverStand.PutNewObject(salver);
        }

        private void PutInConveyor()
        {

        }

        private void DestroySalver(Salver salver)
        {
            Destroy(salver);
        }
    }
}
