﻿using Game.Shapes;
using UnityEngine;

namespace Game.Viewers
{
    class ShapeModelViewer : ShapeViewer<GameObject>
    {
        protected override void InitColorForVisibleObject(Color color, GameObject visibleObject)
        {
            visibleObject.GetComponent<Renderer>().material.color = color;
        }

        protected override void InitVisibleObject(ShapeAsset shapeAsset, GameObject model)
        {
            model = Instantiate(shapeAsset.Model, transform);
            InitColorForVisibleObject(shapeAsset.Color, model);
        }
    }
}
