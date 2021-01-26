using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextLevelBadRoute: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject choices = GameObject.Find("Choice Manager2");
        ChoiceManagerlevel3 interact = choices.GetComponent<ChoiceManagerlevel3>();

        if (other.gameObject.name == "Main Player" && interact.choiceOne == 2)
        {
            SceneManager.LoadScene("Neutral Ending");

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
