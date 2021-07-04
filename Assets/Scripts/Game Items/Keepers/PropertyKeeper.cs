using System;
using UnityEngine;

namespace GameItems.Keepers
{
    public abstract class PropertyKeeper<T, E> : ScriptableObject, IPropertyKeeper<T, E>
    {
        private const string _errorMessage = "Property not set";

        public abstract T GetProperty(E type);

        protected void SendErrorMessage()
        {
            Debug.LogError(_errorMessage);
        }
    }
}
