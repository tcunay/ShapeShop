using UnityEngine;
using Game.Shapes;
using Game.Types;

namespace Game.Viewers
{
    public abstract class ShapeViewer<T> : MonoBehaviour where T : Object
    {
        private ShapeAsset _shapeAsset;
        private ShapeType _type;
        private Color _color;

        protected T VisibleObject;

        //public T 
        public Color Color => _color;
        public ShapeType Type => _type;

        protected abstract void InitVisibleObject(ShapeAsset shapeAsset);

        protected abstract void InitColorForVisibleObject(Color color, T visibleObject);

        public virtual void Init(ShapeAsset shapeAsset)
        {
            _shapeAsset = shapeAsset;
            _color = shapeAsset.Color;
            InitType(shapeAsset.ShapeType);
            InitVisibleObject(shapeAsset);
        }

        //private void InitModel(GameObject model, Color color)
        //{
        //    _model = Instantiate(model, transform);
        //    _model.GetComponent<Renderer>().material.color = color;
        //}

        //private void InitIcon(Sprite sprite, Color color)
        //{
        //    _icon.sprite = sprite;
        //    _icon.color = color;
        //}

        private void InitType(ShapeType type)
        {
            _type = type;
        }
    }
}
