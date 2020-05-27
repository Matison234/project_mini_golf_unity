using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Rigidbody2D`. Inherits from `AtomEvent&lt;Rigidbody2D&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Rigidbody2D", fileName = "Rigidbody2DEvent")]
    public sealed class Rigidbody2DEvent : AtomEvent<Rigidbody2D> { }
}
