using Game.Keepers;
using UnityEngine;

namespace Game.Assets
{
    public abstract class Asset : ScriptableObject
    {
        [SerializeField] private ColorsKeeper _color;
    }
}

