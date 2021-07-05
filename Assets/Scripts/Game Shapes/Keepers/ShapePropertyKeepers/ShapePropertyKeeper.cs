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
            switch (type.Model)
            {
                case ShapeModelType.None:
                    SendErrorMessage();
                    return default;
                case ShapeModelType.Sphere:
                    return _sphere;
                case ShapeModelType.Cube:
                    return _cube;
                case ShapeModelType.Parallelepiped:
                    return _parallelepiped;
                default:
                    SendErrorMessage();
                    return default;
            }
        }
    }
}
