#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Rigidbody2D`. Inherits from `AtomDrawer&lt;Rigidbody2DConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Rigidbody2DConstant))]
    public class Rigidbody2DConstantDrawer : VariableDrawer<Rigidbody2DConstant> { }
}
#endif
