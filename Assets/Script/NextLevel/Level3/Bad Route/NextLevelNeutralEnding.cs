using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextLevelNeutralEnding : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject choices = GameObject.Find("Choice Manager3");
        ChoiceManagerlevel3BadRoute interact = choices.GetComponent<ChoiceManagerlevel3BadRoute>();

        if (other.gameObject.name == "Main Player" && interact.choiceOne == 1)
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
