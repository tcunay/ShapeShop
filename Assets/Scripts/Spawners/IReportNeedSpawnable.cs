using System;
using Game.Shapes;

namespace Game.Spawners
{
    public interface IReportNeedSpawnable
    {
        public event Action<ShapeAsset> SpawnNeeded;
    }
}