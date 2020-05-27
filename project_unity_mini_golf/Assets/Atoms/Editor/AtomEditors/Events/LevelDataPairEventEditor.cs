#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `LevelDataPair`. Inherits from `AtomEventEditor&lt;LevelDataPair, LevelDataPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LevelDataPairEvent))]
    public sealed class LevelDataPairEventEditor : AtomEventEditor<LevelDataPair, LevelDataPairEvent> { }
}
#endif
