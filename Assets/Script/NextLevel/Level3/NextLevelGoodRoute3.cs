using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextLevelGoodRoute3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject choices = GameObject.Find("Choice Manager2");
        ChoiceManagerlevel3 interact = choices.GetComponent<ChoiceManagerlevel3>();

        if (other.gameObject.name == "Main Player" && interact.choiceOne == 1)
        {
            SceneManager.LoadScene("Good Ending");

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
