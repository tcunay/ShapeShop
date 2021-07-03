using Game.Enums;
using UnityEngine;

namespace Game.Keepers
{
    [System.Serializable]
    public class ModelsKeeper : IPropertyKeeper<GameObject>
    {
        [SerializeField] private readonly GameObject _sphere;
        [SerializeField] private readonly GameObject _cube;
        [SerializeField] private readonly GameObject _parallelepiped;

        private const string _errorMessage = "Shape not set";

        private ShapeType _type;

        public ShapeType Type => _type;

        public void Init(ShapeType type)
        {
            _type = type;
        }

        public GameObject GetProperty()
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
