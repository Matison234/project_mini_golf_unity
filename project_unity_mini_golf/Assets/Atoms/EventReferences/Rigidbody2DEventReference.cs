using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Rigidbody2D`. Inherits from `AtomEventReference&lt;Rigidbody2D, Rigidbody2DVariable, Rigidbody2DEvent, Rigidbody2DVariableInstancer, Rigidbody2DEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Rigidbody2DEventReference : AtomEventReference<
        Rigidbody2D,
        Rigidbody2DVariable,
        Rigidbody2DEvent,
        Rigidbody2DVariableInstancer,
        Rigidbody2DEventInstancer>, IGetEvent 
    { }
}
