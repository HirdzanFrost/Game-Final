
using UnityEngine;

public class InteractEnemy : MonoBehaviour
{
    public float radius = 3f;
    bool isfocus = false;
    Transform player;
    bool hasinteract = false;

    public void Update()
    {
        if (isfocus && !hasinteract)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                interact();
                Debug.Log("interact with enemy");
                hasinteract = true;
            }
        }
    }

    public virtual void interact()
    {

    }


    public void Onfocus(Transform playerTransform)
    {

        isfocus = true;
        player = playerTransform;
        hasinteract = false;
    }

    public void Notfocus()
    {
        isfocus = false;
        player = null;
        hasinteract = false;
    }
     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
