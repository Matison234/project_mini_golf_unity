using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `LevelDataPair`. Inherits from `AtomEventReference&lt;LevelDataPair, LevelDataVariable, LevelDataPairEvent, LevelDataVariableInstancer, LevelDataPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LevelDataPairEventReference : AtomEventReference<
        LevelDataPair,
        LevelDataVariable,
        LevelDataPairEvent,
        LevelDataVariableInstancer,
        LevelDataPairEventInstancer>, IGetEvent 
    { }
}
