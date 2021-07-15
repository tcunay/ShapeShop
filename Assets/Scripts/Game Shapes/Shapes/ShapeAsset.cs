using UnityEngine;
using Game.Types;
using Game.Libraries;
using UnityEngine.Tilemaps;

namespace Game.Shapes
{
    [CreateAssetMenu(fileName = "ShapeAsset", menuName = "Assets/Shape", order = 51)]
    public class ShapeAsset : TileBase
    {
        [SerializeField] private ShapeKeepersLibrary _shapeKeepersLibrary;
        [SerializeField] private ShapeType _shapeType;

        public GameObject ModelContainer => _shapeKeepersLibrary.ModelKeeper.GetProperty(_shapeType);
        public Sprite Icon => _shapeKeepersLibrary.IconKeeper.GetProperty(_shapeType);
        public Color Color => _shapeKeepersLibrary.ColorKeeper.GetProperty(_shapeType);
        public ShapeType ShapeType => _shapeType;
    }
}
