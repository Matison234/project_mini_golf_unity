using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Rigidbody2D&gt;`. Inherits from `IPair&lt;Rigidbody2D&gt;`.
    /// </summary>
    [Serializable]
    public struct Rigidbody2DPair : IPair<Rigidbody2D>
    {
        public Rigidbody2D Item1 { get => _item1; set => _item1 = value; }
        public Rigidbody2D Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Rigidbody2D _item1;
        [SerializeField]
        private Rigidbody2D _item2;

        public void Deconstruct(out Rigidbody2D item1, out Rigidbody2D item2) { item1 = Item1; item2 = Item2; }
    }
}