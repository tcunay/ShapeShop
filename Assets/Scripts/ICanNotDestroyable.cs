using System;
using Game.Salvers;

public interface ICanNotDestroyable
{
    public event Action<Salver> NeededDestroy;
}
