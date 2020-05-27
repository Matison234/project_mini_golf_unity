using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `LevelDataPair`. Inherits from `AtomEventReferenceListener&lt;LevelDataPair, LevelDataPairEvent, LevelDataPairEventReference, LevelDataPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/LevelDataPair Event Reference Listener")]
    public sealed class LevelDataPairEventReferenceListener : AtomEventReferenceListener<
        LevelDataPair,
        LevelDataPairEvent,
        LevelDataPairEventReference,
        LevelDataPairUnityEvent>
    { }
}
