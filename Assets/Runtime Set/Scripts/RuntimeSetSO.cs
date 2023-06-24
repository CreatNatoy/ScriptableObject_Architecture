using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Runtime_Set.Scripts
{
    public abstract class RuntimeSetSO<T> : ScriptableObject
    {
        [ShowInInspector]
        public List<T> Items { get; } = new List<T>();

        public void Add(T item)
        {
            if(!Items.Contains(item))
                Items.Add(item);
        }

        public void Remove(T item)
        {
            if (Items.Contains(item))
                Items.Remove(item);
        }

        public void RemoveAll() => Items.Clear();
    }
}
