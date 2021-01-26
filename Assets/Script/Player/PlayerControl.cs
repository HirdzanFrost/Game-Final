using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(PlayerMove))]

public class PlayerControl : MonoBehaviour
{
    public LayerMask movemementmask;
    Camera cam;
    PlayerMove move;
    public InteractEnemy focus;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        move = GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, movemementmask))
            {
                move.Movetopoint(hit.point);
                removefocus();
            }         
        }

        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                InteractEnemy interactenemy = hit.collider.GetComponent<InteractEnemy>();
                if (interactenemy != null)
                {
                    SetFocus(interactenemy);
                }
            }
        }
    }

    void SetFocus(InteractEnemy newfocus)
    {    if (newfocus != focus)
        {
            if (focus != null)
                focus.Notfocus();
            focus = newfocus;
            move.FollowTarget(newfocus);

        }

        newfocus.Onfocus(transform);
    }
    void removefocus()
    {
        if(focus != null)
            focus.Notfocus();
        focus = null;
        move.StopFollow();
    }
}
