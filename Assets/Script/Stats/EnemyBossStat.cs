using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossStat : GeneralStats
{
    
    public override void die()
    {
        base.die();

        if (curenthealth <= 0)
        {
            gameObject.GetComponent<EnemyAI>().enabled = false;
            gameObject.GetComponent<Enemy>().enabled = false;
            gameObject.GetComponent<GeneralCombat>().enabled = false;
            gameObject.GetComponent<InteractDialogue1>().enabled = true;
            
        }
    }
}
