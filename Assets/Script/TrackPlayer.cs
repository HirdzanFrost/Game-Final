using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    
    // Start is called before the first frame update
    #region singleton
    public static TrackPlayer instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject Player;
}
