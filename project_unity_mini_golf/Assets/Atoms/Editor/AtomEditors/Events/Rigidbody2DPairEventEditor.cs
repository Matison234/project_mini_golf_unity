#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Rigidbody2DPair`. Inherits from `AtomEventEditor&lt;Rigidbody2DPair, Rigidbody2DPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Rigidbody2DPairEvent))]
    public sealed class Rigidbody2DPairEventEditor : AtomEventEditor<Rigidbody2DPair, Rigidbody2DPairEvent> { }
}
#endif
