using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GeneralStats))]
public class Enemy : InteractEnemy
{

    TrackPlayer trackplayer;
    GeneralStats mystat;

    private void Start()
    {
        trackplayer = TrackPlayer.instance;
        mystat = GetComponent<GeneralStats>();
    }
    public override void interact()
    {
        base.interact();
        GeneralCombat playercombat = trackplayer.Player.GetComponent<GeneralCombat>();
        if (playercombat != null)
        {
            playercombat.attack(mystat);
        }
    }
}
