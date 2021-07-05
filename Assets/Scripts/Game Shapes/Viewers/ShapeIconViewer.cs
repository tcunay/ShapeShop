using UnityEngine;
using UnityEngine.UI;
using Game.Shapes;

namespace Game.Viewers
{
    public class ShapeIconViewer : ShapeViewer<Image>
    {
        protected override void InitColorForVisibleObject(Color color, Image visibleObject)
        {
            visibleObject.color = color;
        }

        protected override void InitVisibleObject(ShapeAsset shapeAsset, Image icon)
        {
            icon.sprite = shapeAsset.Icon;
            InitColorForVisibleObject(shapeAsset.Color, icon);
        }
    }
}
