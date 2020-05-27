#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `LevelData`. Inherits from `AtomDrawer&lt;LevelDataConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LevelDataConstant))]
    public class LevelDataConstantDrawer : VariableDrawer<LevelDataConstant> { }
}
#endif
