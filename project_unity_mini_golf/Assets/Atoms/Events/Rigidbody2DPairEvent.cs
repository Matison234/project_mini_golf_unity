using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Rigidbody2DPair`. Inherits from `AtomEvent&lt;Rigidbody2DPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Rigidbody2DPair", fileName = "Rigidbody2DPairEvent")]
    public sealed class Rigidbody2DPairEvent : AtomEvent<Rigidbody2DPair> { }
}
