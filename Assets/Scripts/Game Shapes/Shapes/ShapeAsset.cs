using UnityEngine;
using Game.Types;
using Game.Libraries;

namespace Game.Shapes
{
    [CreateAssetMenu(fileName = "ShapeAsset", menuName = "Assets/Shape", order = 51)]
    public class ShapeAsset : ScriptableObject
    {
        [SerializeField] private ShapeKeepersLibrary _shapeKeepersLibrary;
        [SerializeField] private ShapeType _shapeType;

        public GameObject Model => _shapeKeepersLibrary.ModelKeeper.GetProperty(_shapeType);
        public Sprite Icon => _shapeKeepersLibrary.IconKeeper.GetProperty(_shapeType);
        public Color Color => _shapeKeepersLibrary.ColorKeeper.GetProperty(_shapeType);
        public ShapeType ShapeType => _shapeType;
    }
}
