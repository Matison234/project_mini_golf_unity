using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Rigidbody2D`. Inherits from `AtomVariable&lt;Rigidbody2D, Rigidbody2DPair, Rigidbody2DEvent, Rigidbody2DPairEvent, Rigidbody2DRigidbody2DFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Rigidbody2D", fileName = "Rigidbody2DVariable")]
    public sealed class Rigidbody2DVariable : AtomVariable<Rigidbody2D, Rigidbody2DPair, Rigidbody2DEvent, Rigidbody2DPairEvent, Rigidbody2DRigidbody2DFunction>
    {
        protected override bool ValueEquals(Rigidbody2D other)
        {
            throw new NotImplementedException();
        }
    }
}
