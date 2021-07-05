using System;
using Game.Shapes;
using Game.Viewers;
using UnityEngine;

namespace Game.Spawners
{
    public interface IShapeSpawner
    {
        void Spawn(ShapeViewer shapeViewer, ShapeAsset shapeAsset);
    }
}
