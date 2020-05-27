using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `LevelData`. Inherits from `AtomEventInstancer&lt;LevelData, LevelDataEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/LevelData Event Instancer")]
    public class LevelDataEventInstancer : AtomEventInstancer<LevelData, LevelDataEvent> { }
}
