#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Rigidbody2D`. Inherits from `AtomDrawer&lt;Rigidbody2DVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Rigidbody2DVariable))]
    public class Rigidbody2DVariableDrawer : VariableDrawer<Rigidbody2DVariable> { }
}
#endif
