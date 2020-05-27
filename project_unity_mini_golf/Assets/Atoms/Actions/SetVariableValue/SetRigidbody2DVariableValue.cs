using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Rigidbody2D`. Inherits from `SetVariableValue&lt;Rigidbody2D, Rigidbody2DPair, Rigidbody2DVariable, Rigidbody2DConstant, Rigidbody2DReference, Rigidbody2DEvent, Rigidbody2DPairEvent, Rigidbody2DVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Rigidbody2D", fileName = "SetRigidbody2DVariableValue")]
    public sealed class SetRigidbody2DVariableValue : SetVariableValue<
        Rigidbody2D,
        Rigidbody2DPair,
        Rigidbody2DVariable,
        Rigidbody2DConstant,
        Rigidbody2DReference,
        Rigidbody2DEvent,
        Rigidbody2DPairEvent,
        Rigidbody2DRigidbody2DFunction,
        Rigidbody2DVariableInstancer>
    { }
}
