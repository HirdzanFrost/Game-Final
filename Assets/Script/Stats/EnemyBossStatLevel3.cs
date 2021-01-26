using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossStatLevel3 : GeneralStats
{
    
    public override void die()
    {
        base.die();

        if (curenthealth <= 0)
        {
            gameObject.GetComponent<EnemyAI>().enabled = false;
            gameObject.GetComponent<Enemy>().enabled = false;
            gameObject.GetComponent<GeneralCombat>().enabled = false;
            gameObject.GetComponent<InteractDialogueLevel3>().enabled = true;
            
        }
    }
}
