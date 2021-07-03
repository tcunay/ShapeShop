using UnityEngine;
using Game.Keepers;
using Game.Types;

namespace Game.Shapes
{
    [CreateAssetMenu(fileName = "ShapeAsset", menuName = "Assets/Shape", order = 51)]
    public class ShapeAsset : ScriptableObject
    {
        [SerializeField] private ShapePropertyKeeper<GameObject> _model;
        [SerializeField] private ShapePropertyKeeper<Sprite> _icon;
        [SerializeField] private ShapePropertyKeeper<Color> _color;
        [SerializeField] private ShapeType _shapeType;

        public GameObject Model => _model.GetProperty(_shapeType);
        public Sprite Icon => _icon.GetProperty(_shapeType);
        public Color Color => _color.GetProperty(_shapeType);
        public ShapeType ShapeType => _shapeType;
    }
}
