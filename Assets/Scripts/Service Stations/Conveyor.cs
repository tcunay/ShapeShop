using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.ServiceStations
{
    [System.Serializable]
    public class Conveyor
    {
        [SerializeField] private Transform _startPoint;
        [SerializeField] private Transform _endPoint;
        [SerializeField] private float _transportSpeed;

        private Transform _transportedObject;

        public event Action TransportEnded;

        public IEnumerator Transport(Transform transportedObject)
        {
            float time = GetLength() / _transportSpeed;
            for (float i = 0; i < time; i += Time.deltaTime)
            {
                transportedObject.position = Vector3.Lerp(_startPoint.position, _endPoint.position, i);
                yield return null;
            }
            TransportEnded?.Invoke();
        }

        private float GetLength()
        {
            return Vector3.Distance(_startPoint.position, _endPoint.position);
        }
    }
}
