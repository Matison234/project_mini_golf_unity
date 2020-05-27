#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Rigidbody2D`. Inherits from `AtomDrawer&lt;Rigidbody2DValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Rigidbody2DValueList))]
    public class Rigidbody2DValueListDrawer : AtomDrawer<Rigidbody2DValueList> { }
}
#endif
