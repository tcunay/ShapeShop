using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shapes
{
    [CreateAssetMenu(fileName = "ShapeAsset", menuName = "Asset/Shape", order = 51)]
    public class ShapeAsset : ScriptableObject
    {
        [SerializeField] private GameObject _shapeModel;
        [SerializeField] private Sprite _icon;
        [SerializeField] private Color _color;
        [SerializeField] private ShapeType _type;


        public GameObject ShapeModel => _shapeModel;

        public Sprite Icon => _icon;

        public Color Color => _color;

        public ShapeType Type => _type;
    }
}
