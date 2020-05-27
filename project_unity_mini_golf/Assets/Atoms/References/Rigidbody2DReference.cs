using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Rigidbody2D`. Inherits from `AtomReference&lt;Rigidbody2D, Rigidbody2DPair, Rigidbody2DConstant, Rigidbody2DVariable, Rigidbody2DEvent, Rigidbody2DPairEvent, Rigidbody2DRigidbody2DFunction, Rigidbody2DVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Rigidbody2DReference : AtomReference<
        Rigidbody2D,
        Rigidbody2DPair,
        Rigidbody2DConstant,
        Rigidbody2DVariable,
        Rigidbody2DEvent,
        Rigidbody2DPairEvent,
        Rigidbody2DRigidbody2DFunction,
        Rigidbody2DVariableInstancer>, IEquatable<Rigidbody2DReference>
    {
        public Rigidbody2DReference() : base() { }
        public Rigidbody2DReference(Rigidbody2D value) : base(value) { }
        public bool Equals(Rigidbody2DReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Rigidbody2D other)
        {
            throw new NotImplementedException();
        } 
    }
}
