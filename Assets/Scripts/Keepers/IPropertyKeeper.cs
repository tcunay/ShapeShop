using UnityEngine;
namespace Game.Keepers
{
    public interface IPropertyKeeper<T>
    {
        T GetProperty();
    }
}
