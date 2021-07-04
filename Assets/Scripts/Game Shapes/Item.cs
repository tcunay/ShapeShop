using System.Collections;
using System.Collections.Generic;
using Game.Shapes;
using UnityEngine;

namespace Game.Items
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
