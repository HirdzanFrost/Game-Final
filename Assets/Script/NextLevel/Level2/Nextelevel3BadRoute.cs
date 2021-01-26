using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextelevel3BadRoute : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        GameObject choices = GameObject.Find("Choice Manager");
        ChoiceManager1 interact = choices.GetComponent<ChoiceManager1>();

        if (other.gameObject.name == "Main Player" && interact.choiceOne == 2)
        {
            SceneManager.LoadScene("level 3 Bad Route");

        }
    }
    

}
