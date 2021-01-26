
using UnityEngine;

public class GeneralStats : MonoBehaviour
{
    public int maxhealt = 100;
    public int curenthealth  { get; private set; }
    public BaseStats damage;
    public event System.Action<int, int> OnhealthChnaged;
     void Awake()
    {
        curenthealth = maxhealt;
    }

    public void takedamage(int damage)
    {
        curenthealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage");

        if (OnhealthChnaged != null)
        {
            OnhealthChnaged(maxhealt, curenthealth);
        }
        if (curenthealth <= 0){
            die();
        }
    }

    public virtual void die()
    {

    }
}
