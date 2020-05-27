#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Rigidbody2D`. Inherits from `AtomDrawer&lt;Rigidbody2DEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Rigidbody2DEvent))]
    public class Rigidbody2DEventDrawer : AtomDrawer<Rigidbody2DEvent> { }
}
#endif
