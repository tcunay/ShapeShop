using Game.Enums;
using UnityEngine;

namespace Game.Keepers
{
    [System.Serializable]
    class SpritesKeeper : IPropertyKeeper<Sprite>
    {
        [SerializeField] private readonly Sprite _sphere;
        [SerializeField] private readonly Sprite _cube;
        [SerializeField] private readonly Sprite _parallelepiped;

        private const string _errorMessage = "Shape not set";

        private ShapeType _type;

        public ShapeType Type => _type;

        public SpritesKeeper(ShapeType type)
        {
            _type = type;
        }

        public Sprite GetProperty()
        {
            switch (_type)
            {
                case ShapeType.None:
                    Debug.LogError(_errorMessage);
                    return null;
                case ShapeType.Sphere:
                    return _sphere;
                case ShapeType.Cube:
                    return _cube;
                case ShapeType.Parallelepiped:
                    return _parallelepiped;
                default:
                    Debug.LogError(_errorMessage);
                    return null;
            }
        }
    }
}
