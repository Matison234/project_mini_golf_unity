using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Rigidbody2D`. Inherits from `AtomEventReferenceListener&lt;Rigidbody2D, Rigidbody2DEvent, Rigidbody2DEventReference, Rigidbody2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Rigidbody2D Event Reference Listener")]
    public sealed class Rigidbody2DEventReferenceListener : AtomEventReferenceListener<
        Rigidbody2D,
        Rigidbody2DEvent,
        Rigidbody2DEventReference,
        Rigidbody2DUnityEvent>
    { }
}
