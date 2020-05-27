using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Rigidbody2D`. Inherits from `AtomValueList&lt;Rigidbody2D, Rigidbody2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Rigidbody2D", fileName = "Rigidbody2DValueList")]
    public sealed class Rigidbody2DValueList : AtomValueList<Rigidbody2D, Rigidbody2DEvent> { }
}
