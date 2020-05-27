using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Rigidbody2D`. Inherits from `AtomEventInstancer&lt;Rigidbody2D, Rigidbody2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Rigidbody2D Event Instancer")]
    public class Rigidbody2DEventInstancer : AtomEventInstancer<Rigidbody2D, Rigidbody2DEvent> { }
}
