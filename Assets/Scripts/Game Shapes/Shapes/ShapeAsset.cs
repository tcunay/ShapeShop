using UnityEngine;
using Game.Types;
using Game.Libraries;
using UnityEngine.Tilemaps;

namespace Game.Shapes
{
    [CreateAssetMenu(fileName = "ShapeAsset", menuName = "Assets/Shape", order = 51)]
    public class ShapeAsset : Tile
    {
        [SerializeField] private ShapeKeepersLibrary _shapeKeepersLibrary;
        [SerializeField] private ShapeType _shapeType;

        //public ModelContainer ModelContainer => _shapeKeepersLibrary.ModelKeeper.GetProperty(_shapeType);
        public GameObject Model => gameObject = _shapeKeepersLibrary.ModelKeeper.GetProperty(_shapeType).Model;
        public Sprite Icon => sprite = _shapeKeepersLibrary.IconKeeper.GetProperty(_shapeType);
        public Color Color => color = _shapeKeepersLibrary.ColorKeeper.GetProperty(_shapeType);
        public ShapeType ShapeType => _shapeType;
    }
}
