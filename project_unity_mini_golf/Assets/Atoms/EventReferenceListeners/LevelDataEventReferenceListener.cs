using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `LevelData`. Inherits from `AtomEventReferenceListener&lt;LevelData, LevelDataEvent, LevelDataEventReference, LevelDataUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/LevelData Event Reference Listener")]
    public sealed class LevelDataEventReferenceListener : AtomEventReferenceListener<
        LevelData,
        LevelDataEvent,
        LevelDataEventReference,
        LevelDataUnityEvent>
    { }
}
