using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GeneralAnimator : MonoBehaviour
{
    const float smoothtimemove = .1f;
     NavMeshAgent agent;
    protected Animator animator;
    protected AnimatorOverrideController overrideController;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        overrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        float speedPercent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speedPercent, smoothtimemove, Time.deltaTime);
    }
}
