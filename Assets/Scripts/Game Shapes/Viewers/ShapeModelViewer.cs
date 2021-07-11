using Game.Shapes;
using UnityEngine;

namespace Game.Viewers
{
    public class ShapeModelViewer : ShapeViewer
    {
        private GameObject _model;

        public GameObject Model => _model;

        protected override void InitColorForVisibleObject(Color color)
        {
            _model.GetComponent<Renderer>().material.color = color;
        }

        protected override void InitVisibleObject(ShapeAsset shapeAsset)
        {
            _model = Instantiate(shapeAsset.Model, transform);
            InitColorForVisibleObject(shapeAsset.Color);
        }
    }
}
