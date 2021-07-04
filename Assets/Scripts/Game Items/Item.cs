using System.Collections;
using System.Collections.Generic;
using GameItems.Shapes;
using UnityEngine;

namespace GameItems.Items
{
    public class Item : MonoBehaviour
    {
        private ShapeAsset _shapeAsset;

        public ShapeAsset Asset => _shapeAsset;

        public void SetAsset(ShapeAsset shapeAsset)
        {
            _shapeAsset = shapeAsset;
        }
    }
}
