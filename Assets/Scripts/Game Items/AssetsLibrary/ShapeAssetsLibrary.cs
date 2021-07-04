using System.Collections.Generic;
using UnityEngine;
using GameItems.Shapes;

namespace GameItems.AssetsLibrary
{
    [CreateAssetMenu(fileName = "ShapeAssetLibrary", menuName = "Assets/Assets Library/ShapeAssetLibrary", order = 51)]
    public class ShapeAssetsLibrary : ScriptableObject
    {
        [SerializeField] private List<ShapeAsset> _shapeAssets;
    }
}
