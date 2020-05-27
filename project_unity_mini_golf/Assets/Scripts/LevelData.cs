using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "LevelData", menuName ="Minigolf/LevelData")]

public class LevelData : ScriptableObject, IEquatable<LevelData>
{
    public string SceneName => sceneName;
    [NaughtyAttributes.Scene]
    [SerializeField] private string sceneName;

    public int averageHit;

    public bool Equals(LevelData other)
    {
        if(this == other)
        {
            return true;
        }
        return false;
    }
}
