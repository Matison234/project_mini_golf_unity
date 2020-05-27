using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `LevelData`. Inherits from `EquatableAtomReference&lt;LevelData, LevelDataPair, LevelDataConstant, LevelDataVariable, LevelDataEvent, LevelDataPairEvent, LevelDataLevelDataFunction, LevelDataVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LevelDataReference : EquatableAtomReference<
        LevelData,
        LevelDataPair,
        LevelDataConstant,
        LevelDataVariable,
        LevelDataEvent,
        LevelDataPairEvent,
        LevelDataLevelDataFunction,
        LevelDataVariableInstancer>, IEquatable<LevelDataReference>
    {
        public LevelDataReference() : base() { }
        public LevelDataReference(LevelData value) : base(value) { }
        public bool Equals(LevelDataReference other) { return base.Equals(other); }
    }
}
