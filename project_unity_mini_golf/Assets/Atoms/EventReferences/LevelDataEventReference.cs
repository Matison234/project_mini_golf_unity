using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `LevelData`. Inherits from `AtomEventReference&lt;LevelData, LevelDataVariable, LevelDataEvent, LevelDataVariableInstancer, LevelDataEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LevelDataEventReference : AtomEventReference<
        LevelData,
        LevelDataVariable,
        LevelDataEvent,
        LevelDataVariableInstancer,
        LevelDataEventInstancer>, IGetEvent 
    { }
}
