using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `LevelData`. Inherits from `AtomVariableInstancer&lt;LevelDataVariable, LevelDataPair, LevelData, LevelDataEvent, LevelDataPairEvent, LevelDataLevelDataFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/LevelData Variable Instancer")]
    public class LevelDataVariableInstancer : AtomVariableInstancer<
        LevelDataVariable,
        LevelDataPair,
        LevelData,
        LevelDataEvent,
        LevelDataPairEvent,
        LevelDataLevelDataFunction>
    { }
}
