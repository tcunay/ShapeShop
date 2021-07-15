using UnityEngine;
using Game.Keepers;

namespace Game.Libraries
{
    [CreateAssetMenu(fileName = "ShapeKeepersLibrary", menuName = "Assets/Assets Library/ShapeKeepersLibrary", order = 51)]
    public class ShapeKeepersLibrary : ScriptableObject
    {
        [SerializeField] private ShapePropertyKeeper<ModelContainer> _modelKeeper;
        [SerializeField] private ShapePropertyKeeper<Sprite> _iconKeeper;
        [SerializeField] private ShapePropertyKeeper<Color> _colorKeeper;

        public ShapePropertyKeeper<ModelContainer> ModelKeeper => _modelKeeper;
        public ShapePropertyKeeper<Sprite> IconKeeper => _iconKeeper;
        public ShapePropertyKeeper<Color> ColorKeeper => _colorKeeper;
    }
}
