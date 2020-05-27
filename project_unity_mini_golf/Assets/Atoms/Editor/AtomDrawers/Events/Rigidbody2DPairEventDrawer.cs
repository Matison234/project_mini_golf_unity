#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Rigidbody2DPair`. Inherits from `AtomDrawer&lt;Rigidbody2DPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Rigidbody2DPairEvent))]
    public class Rigidbody2DPairEventDrawer : AtomDrawer<Rigidbody2DPairEvent> { }
}
#endif
