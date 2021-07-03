using UnityEngine;
using Game.Enums;

namespace Game.Keepers
{
    [System.Serializable]
    public class ColorsKeeper: IPropertyKeeper<Color>
    {
        [SerializeField] private ColorType _type;

        private const string _errorMessage = "Color not set";

        public ColorType Type => _type;

        public Color GetProperty()
        {
            switch (_type)
            {
                case ColorType.None:
                    Debug.LogError(_errorMessage);
                    return Color.black;
                case ColorType.Red:
                    return Color.red;
                case ColorType.Green:
                    return Color.green;
                case ColorType.Blue:
                    return Color.blue;
                default:
                    Debug.LogError(_errorMessage);
                    return Color.black;
            }
        }
    }
}
