using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Rigidbody2D`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Rigidbody2DVariable))]
    public sealed class Rigidbody2DVariableEditor : AtomVariableEditor<Rigidbody2D, Rigidbody2DPair> { }
}
