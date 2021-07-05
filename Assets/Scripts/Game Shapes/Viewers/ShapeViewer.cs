using UnityEngine;
using Game.Shapes;
using Game.Types;

namespace Game.Viewers
{
    public abstract class ShapeViewer<T> : MonoBehaviour where T : Object
    {
        private T _visibleObject;
        private ShapeAsset _shapeAsset;
        private ShapeType _type;
        private Color _color;

        public T VisibleObject => _visibleObject;
        public Color Color => _color;
        public ShapeType Type => _type;

        protected abstract void InitVisibleObject(ShapeAsset shapeAsset, T visibleObject);

        protected abstract void InitColorForVisibleObject(Color color, T visibleObject);

        public virtual void Init(ShapeAsset shapeAsset)
        {
            _shapeAsset = shapeAsset;
            _color = shapeAsset.Color;
            InitType(shapeAsset.ShapeType);
            InitVisibleObject(shapeAsset , _visibleObject);
        }

        private void InitType(ShapeType type)
        {
            _type = type;
        }
    }
}
