using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Rigidbody2DPair`. Inherits from `AtomEventReference&lt;Rigidbody2DPair, Rigidbody2DVariable, Rigidbody2DPairEvent, Rigidbody2DVariableInstancer, Rigidbody2DPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Rigidbody2DPairEventReference : AtomEventReference<
        Rigidbody2DPair,
        Rigidbody2DVariable,
        Rigidbody2DPairEvent,
        Rigidbody2DVariableInstancer,
        Rigidbody2DPairEventInstancer>, IGetEvent 
    { }
}
