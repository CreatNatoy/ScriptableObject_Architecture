using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ServiceLocator.Scripts
{
    [CreateAssetMenu(menuName = "ScriptableObject/ServiceLocatorSo")]
    public class ServiceLocatorSo : ScriptableObject
    {
        [ShowInInspector]
        private readonly Dictionary<Type, object> _services = new();

        public void Register<T>(T service)
        {
            if (_services.ContainsKey(typeof(T)))
            {
                Debug.LogError($"We have this {typeof(T)} object at Service Locator");
                return;
            }

            _services[typeof(T)] = service; 
        }

        public T Get<T>()
        {
            if (_services.TryGetValue(typeof(T), out object value))
                return (T)value; 
            
            Debug.LogError($"Service of type {typeof(T)} not found.");
            return default; 
        }

        public void Remove<T>()
        {
            if (_services.ContainsKey(typeof(T))) 
                _services.Remove(typeof(T));
            else
                Debug.LogError($"Service of type {typeof(T)} not found.");
        }
    }
}
