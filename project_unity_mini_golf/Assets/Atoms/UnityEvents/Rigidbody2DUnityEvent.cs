using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Rigidbody2D`. Inherits from `UnityEvent&lt;Rigidbody2D&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Rigidbody2DUnityEvent : UnityEvent<Rigidbody2D> { }
}
