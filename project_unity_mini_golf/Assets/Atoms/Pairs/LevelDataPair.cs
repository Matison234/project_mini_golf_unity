using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;LevelData&gt;`. Inherits from `IPair&lt;LevelData&gt;`.
    /// </summary>
    [Serializable]
    public struct LevelDataPair : IPair<LevelData>
    {
        public LevelData Item1 { get => _item1; set => _item1 = value; }
        public LevelData Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private LevelData _item1;
        [SerializeField]
        private LevelData _item2;

        public void Deconstruct(out LevelData item1, out LevelData item2) { item1 = Item1; item2 = Item2; }
    }
}