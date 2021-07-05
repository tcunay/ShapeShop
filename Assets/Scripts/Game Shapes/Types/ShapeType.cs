using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Types
{
    [System.Serializable]
    public struct ShapeType
    {
        [SerializeField] private ShapeModelType _model;

        public ShapeModelType Model => _model;
    }
}
