using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractDialogue1 : MonoBehaviour
{
    public float range = 3f;
    public Transform player;
    bool inrange = false;
    public GameObject dpanel;
    public Dialogue1 dialogue1;
    public int choice1;
    public GameObject choicepanel;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    } 
    private void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance <= range && inrange == false && Input.GetKeyDown(KeyCode.F))   
        {
            Debug.Log("Interact");
            inrange = true;

            choice1 = 1;
                dpanel.SetActive(true);
                dialoguetrigerr();  
           
        }
        else if (distance >= range && inrange == true ) 
        {
            Debug.Log("Not Interact");
            inrange = false;
            dpanel.SetActive(false);
            choicepanel.SetActive(false);
            
        }
    }

    public void dialoguetrigerr()
    {
        FindObjectOfType<DialogueManager1>().StarDialogue(dialogue1);
    }
}
