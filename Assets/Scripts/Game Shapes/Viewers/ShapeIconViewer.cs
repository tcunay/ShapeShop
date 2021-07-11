using UnityEngine;
using UnityEngine.UI;
using Game.Shapes;

namespace Game.Viewers
{
    public class ShapeIconViewer : ShapeViewer
    {
        [SerializeField] private Image _icon;

        public Image Icon => _icon;

        protected override void InitColorForVisibleObject(Color color)
        {
            _icon.color = color;
        }

        protected override void InitVisibleObject(ShapeAsset shapeAsset)
        {
            _icon.sprite = shapeAsset.Icon;
            InitColorForVisibleObject(shapeAsset.Color);
        }
    }
}
