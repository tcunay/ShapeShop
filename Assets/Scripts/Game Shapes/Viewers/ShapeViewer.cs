using UnityEngine;
using Game.Shapes;
using Game.Types;

namespace Game.Viewers
{
    public abstract class ShapeViewer : MonoBehaviour
    {
        private ShapeAsset _shapeAsset;
        private Color _color;
        private ShapeModelType _type;

        public ShapeAsset Asset => _shapeAsset;
        public Color Color => _color;
        public ShapeModelType Type => _type;

        protected abstract void InitVisibleObject(ShapeAsset shapeAsset);

        protected abstract void InitColorForVisibleObject(Color color);

        public void Init(ShapeAsset shapeAsset)
        {
            _shapeAsset = shapeAsset;
            _color = shapeAsset.Color;
            InitType(shapeAsset.ShapeType.Model);
            InitVisibleObject(shapeAsset);
        }

        private void InitType(ShapeModelType type)
        {
            _type = type;
        }
    }
}
