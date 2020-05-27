using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `LevelData`. Inherits from `EquatableAtomVariable&lt;LevelData, LevelDataPair, LevelDataEvent, LevelDataPairEvent, LevelDataLevelDataFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/LevelData", fileName = "LevelDataVariable")]
    public sealed class LevelDataVariable : EquatableAtomVariable<LevelData, LevelDataPair, LevelDataEvent, LevelDataPairEvent, LevelDataLevelDataFunction> { }
}
