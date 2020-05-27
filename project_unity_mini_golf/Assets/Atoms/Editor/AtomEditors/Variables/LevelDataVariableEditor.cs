using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `LevelData`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(LevelDataVariable))]
    public sealed class LevelDataVariableEditor : AtomVariableEditor<LevelData, LevelDataPair> { }
}
