using System.Collections.Generic;
using UnityEngine;
using Game.Shapes;

namespace Game.AssetsLibrary
{
    [CreateAssetMenu(fileName = "ShapeAssetLibrary", menuName = "Assets/Assets Library/ShapeAssetLibrary", order = 51)]
    public class ShapeAssetsLibrary : ScriptableObject
    {
        [SerializeField] private List<ShapeAsset> _shapeAssets;

        public List<ShapeAsset> Assets => _shapeAssets;
    }
}
