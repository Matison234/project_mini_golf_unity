using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `LevelData`. Inherits from `UnityEvent&lt;LevelData&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LevelDataUnityEvent : UnityEvent<LevelData> { }
}
