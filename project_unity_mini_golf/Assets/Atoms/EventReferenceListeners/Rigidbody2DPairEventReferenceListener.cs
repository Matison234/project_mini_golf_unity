using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Rigidbody2DPair`. Inherits from `AtomEventReferenceListener&lt;Rigidbody2DPair, Rigidbody2DPairEvent, Rigidbody2DPairEventReference, Rigidbody2DPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Rigidbody2DPair Event Reference Listener")]
    public sealed class Rigidbody2DPairEventReferenceListener : AtomEventReferenceListener<
        Rigidbody2DPair,
        Rigidbody2DPairEvent,
        Rigidbody2DPairEventReference,
        Rigidbody2DPairUnityEvent>
    { }
}
