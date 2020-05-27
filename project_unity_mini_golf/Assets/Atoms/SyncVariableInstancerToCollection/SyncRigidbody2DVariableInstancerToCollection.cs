using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Rigidbody2D to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Rigidbody2D Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncRigidbody2DVariableInstancerToCollection : SyncVariableInstancerToCollection<Rigidbody2D, Rigidbody2DVariable, Rigidbody2DVariableInstancer> { }
}
