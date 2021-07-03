using UnityEngine;
using Game.Types;

namespace Game.Keepers
{
    public abstract class ShapePropertyKeeper<T> : PropertyKeeper<T, ShapeType>
    {
        [SerializeField] private T _sphere;
        [SerializeField] private T _cube;
        [SerializeField] private T _parallelepiped;

        public override T GetProperty(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.None:
                    SendErrorMessage();
                    return default;
                case ShapeType.Sphere:
                    return _sphere;
                case ShapeType.Cube:
                    return _cube;
                case ShapeType.Parallelepiped:
                    return _parallelepiped;
                default:
                    SendErrorMessage();
                    return default;
            }
        }
    }
}
