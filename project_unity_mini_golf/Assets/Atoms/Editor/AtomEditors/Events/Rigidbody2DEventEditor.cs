#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Rigidbody2D`. Inherits from `AtomEventEditor&lt;Rigidbody2D, Rigidbody2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Rigidbody2DEvent))]
    public sealed class Rigidbody2DEventEditor : AtomEventEditor<Rigidbody2D, Rigidbody2DEvent> { }
}
#endif
