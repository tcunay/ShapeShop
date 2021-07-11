using UnityEngine;
using UnityEngine.UI;
using Game.Shapes;

namespace Game.Viewers
{
    [RequireComponent(typeof(Image))]
    public class ShapeIconViewer : ShapeViewer
    {
        private Image _icon;

        public Image Icon => _icon;

        private void Awake()
        {
            _icon = GetComponent<Image>();
        }

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
