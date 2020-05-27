#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `LevelData`. Inherits from `AtomDrawer&lt;LevelDataValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LevelDataValueList))]
    public class LevelDataValueListDrawer : AtomDrawer<LevelDataValueList> { }
}
#endif
