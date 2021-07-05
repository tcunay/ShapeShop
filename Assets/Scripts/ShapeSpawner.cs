using Game.Shapes;
using Game.Viewers;

namespace Game.Spawners
{
    public class ShapeSpawner : IShapeSpawner
    {
        public void Spawn(ShapeViewer shapeViewer, ShapeAsset shapeAsset)
        {
            shapeViewer.Init(shapeAsset);
        }
    }
}