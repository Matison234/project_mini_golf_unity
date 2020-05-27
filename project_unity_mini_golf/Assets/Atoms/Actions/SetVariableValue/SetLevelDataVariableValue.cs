using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `LevelData`. Inherits from `SetVariableValue&lt;LevelData, LevelDataPair, LevelDataVariable, LevelDataConstant, LevelDataReference, LevelDataEvent, LevelDataPairEvent, LevelDataVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/LevelData", fileName = "SetLevelDataVariableValue")]
    public sealed class SetLevelDataVariableValue : SetVariableValue<
        LevelData,
        LevelDataPair,
        LevelDataVariable,
        LevelDataConstant,
        LevelDataReference,
        LevelDataEvent,
        LevelDataPairEvent,
        LevelDataLevelDataFunction,
        LevelDataVariableInstancer>
    { }
}
