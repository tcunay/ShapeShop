namespace Game.Keepers
{
    public interface IPropertyKeeper<T,E>
    {
        T GetProperty(E type);
    }
}
