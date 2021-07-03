using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Assets;
using Game.Keepers;
using Game.Enums;

namespace Game.Shapes
{
    [CreateAssetMenu(fileName = "ShapeAsset", menuName = "Asset/Shape", order = 51)]
    public class ShapeAsset : Asset
    {
        [SerializeField] private ModelsKeeper _model;
        [SerializeField] private SpritesKeeper _icon;
        [SerializeField] private ColorsKeeper _color;
        [SerializeField] private ShapeType _type;


        //public GameObject Model => _model.GetProperty();

        //public Sprite Icon => _icon;

        //public Color Color => _color;

        //public ShapeType Type => _type;
    }
}
