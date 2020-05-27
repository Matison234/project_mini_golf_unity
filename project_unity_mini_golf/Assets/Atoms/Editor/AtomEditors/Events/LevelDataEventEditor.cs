#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `LevelData`. Inherits from `AtomEventEditor&lt;LevelData, LevelDataEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LevelDataEvent))]
    public sealed class LevelDataEventEditor : AtomEventEditor<LevelData, LevelDataEvent> { }
}
#endif
