using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GeneralStats))]
public class HealthBar : MonoBehaviour
{
    public GameObject uiPrefab;
    public Transform target;
    //public Transform target;

    Transform Ui;
    Image healtslider;
    Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
        foreach(Canvas c in FindObjectsOfType<Canvas>())

        {
            if (c.renderMode == RenderMode.WorldSpace)
            {
                Ui = Instantiate(uiPrefab, c.transform).transform;
                healtslider = Ui.GetChild(0).GetComponent<Image>();
                break;
            }
        }
        GetComponent<GeneralStats>().OnhealthChnaged += onHealtChanged;
    }

    // Update is called once per frame
    void Update()
    {
        if (Ui != null)
        {
            Ui.position = target.position;
            Ui.forward = -cam.forward;
        }
          
    }

    void onHealtChanged(int maxHealth, int currentHealth)

    {
        if (Ui != null)
        {
            Ui.gameObject.SetActive(true); 
            float healthpercent = (float)currentHealth / maxHealth;
            healtslider.fillAmount = healthpercent;
            if (currentHealth <= 0)
            {
                Destroy(Ui.gameObject);
            }
        }
       
    }
    
}
