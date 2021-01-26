 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{

    public float range = 10f;

    Transform target;
    NavMeshAgent agent;
    GeneralCombat combat;
    // Start is called before the first frame update
    void Start()
    {
        target = TrackPlayer.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<GeneralCombat>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= range)
        {
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                GeneralStats targetstat = target.GetComponent<GeneralStats>();
                if (targetstat != null)
                {
                    combat.attack(targetstat);
                }
                
                facetarget();
            }
        }
        
    }


    void facetarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotataion = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotataion, Time.deltaTime * 5f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
