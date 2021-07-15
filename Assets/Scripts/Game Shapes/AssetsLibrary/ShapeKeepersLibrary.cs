using UnityEngine;
using Game.Keepers;

namespace Game.Libraries
{
    [CreateAssetMenu(fileName = "ShapeKeepersLibrary", menuName = "Assets/Assets Library/ShapeKeepersLibrary", order = 51)]
    public class ShapeKeepersLibrary : ScriptableObject
    {
        [SerializeField] private ShapePropertyKeeper<GameObject> _modelKeeper;
        [SerializeField] private ShapePropertyKeeper<Sprite> _iconKeeper;
        [SerializeField] private ShapePropertyKeeper<Color> _colorKeeper;

        public ShapePropertyKeeper<GameObject> ModelKeeper => _modelKeeper;
        public ShapePropertyKeeper<Sprite> IconKeeper => _iconKeeper;
        public ShapePropertyKeeper<Color> ColorKeeper => _colorKeeper;
    }
}
