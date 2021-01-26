using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : GeneralStats
{
    public GameObject Continue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void die()
    {
        Continue.SetActive(true);
        base.die();
        Debug.Log(transform.name + "die");

    }

   
}
