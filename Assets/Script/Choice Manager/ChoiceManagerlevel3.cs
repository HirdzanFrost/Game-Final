using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChoiceManagerlevel3 : MonoBehaviour
{
    [SerializeField]
    public GameObject textbox;
    public GameObject choice1;
    public GameObject choice2;
    public int choiceOne;
    public GameObject gate;

    //public int choicemade;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void ChoiceOne()
    {
        textbox.GetComponent<Text>().text = "tak ku sangka kau. Baiklah masuk gerbang kedua dibelakan gunung";
        choiceOne = 1;
    }
    public void ChoiceTwo()
    {
        textbox.GetComponent<Text>().text = "jadi itu pilihan mu";
        choiceOne = 2;
    }

    // Update is called once per frame
    void Update()
    {

        if (choiceOne >= 1)
        {
            choice1.SetActive(false);
            choice2.SetActive(false);

        }
        gate1();
    }
   
    public void gate1()
    {
        
        if (choiceOne == 1)
        {
            gate.SetActive(true);
        }
    }

}
