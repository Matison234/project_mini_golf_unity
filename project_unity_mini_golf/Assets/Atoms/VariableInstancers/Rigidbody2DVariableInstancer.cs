using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Rigidbody2D`. Inherits from `AtomVariableInstancer&lt;Rigidbody2DVariable, Rigidbody2DPair, Rigidbody2D, Rigidbody2DEvent, Rigidbody2DPairEvent, Rigidbody2DRigidbody2DFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Rigidbody2D Variable Instancer")]
    public class Rigidbody2DVariableInstancer : AtomVariableInstancer<
        Rigidbody2DVariable,
        Rigidbody2DPair,
        Rigidbody2D,
        Rigidbody2DEvent,
        Rigidbody2DPairEvent,
        Rigidbody2DRigidbody2DFunction>
    { }
}
