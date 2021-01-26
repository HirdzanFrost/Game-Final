using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    public GameObject choices;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject choices = GameObject.Find("NPC1");
        InteractDialogue interact = choices.GetComponent<InteractDialogue>();
        
        if (other.gameObject.name == "Main Player" && interact.choice1 == 1)
        {
            SceneManager.LoadScene("level 2");
        }

    } 

    public void nextlvl1()
    {
        SceneManager.LoadScene("level 1");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ulangi()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }

    public void credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
