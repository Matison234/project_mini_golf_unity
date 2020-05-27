using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `LevelData`. Inherits from `AtomEvent&lt;LevelData&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/LevelData", fileName = "LevelDataEvent")]
    public sealed class LevelDataEvent : AtomEvent<LevelData> { }
}
