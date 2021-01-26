using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : GeneralStats
{

    public override void die()
    {
        base.die();
        Destroy(gameObject);
    }
}
