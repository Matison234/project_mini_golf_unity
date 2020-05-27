using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `LevelData`. Inherits from `AtomValueList&lt;LevelData, LevelDataEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/LevelData", fileName = "LevelDataValueList")]
    public sealed class LevelDataValueList : AtomValueList<LevelData, LevelDataEvent> { }
}
