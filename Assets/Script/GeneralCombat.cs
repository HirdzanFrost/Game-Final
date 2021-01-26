using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GeneralStats))]
public class GeneralCombat : MonoBehaviour
{
    public float attackspeed = 1f;
    private float attackcooldown = 0f;
    public float attackDelay = .6f;

    public event System.Action Onattack;

    GeneralStats mestat;
    private void Start()
    {
        mestat = GetComponent<GeneralStats>();
    }

    private void Update()
    {
        attackcooldown -= Time.deltaTime;
    }
    public void attack (GeneralStats target)
    {

        if (attackcooldown <= 0f)
        {
            StartCoroutine(dodamage(target, attackDelay));
            attackcooldown = 1f / attackspeed;

        }
    }

    IEnumerator dodamage(GeneralStats stats, float delay)
    {
        yield return new WaitForSeconds(delay);

         stats.takedamage(mestat.damage.getvalue());

    }
}
