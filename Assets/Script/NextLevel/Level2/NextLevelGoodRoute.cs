using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevelGoodRoute : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject choices = GameObject.Find("Choice Manager");
        ChoiceManager1 interact = choices.GetComponent<ChoiceManager1>();

        if (other.gameObject.name == "Main Player" && interact.choiceOne == 1)
        {
            SceneManager.LoadScene("Level 3 Good Route");

        }
    }
    public void Start()
    {

    }
    
    
}
