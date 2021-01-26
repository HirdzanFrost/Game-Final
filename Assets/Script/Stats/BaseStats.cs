using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseStats
{
    [SerializeField]
    private int basevalue;
    public int getvalue()
    {
        return basevalue;
    }
}
