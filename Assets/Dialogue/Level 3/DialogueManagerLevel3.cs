using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerLevel3 : MonoBehaviour
{
    private Queue<string> kalimat;
    public Text nametext;
    public Text Dialogue;
    public GameObject dpanel;
    public GameObject choicepanel;


    // Start is called before the first frame update
    void Start()
    {
        kalimat = new Queue<string>();
    }

    public void StarDialogue(DialogueLevel3 dialogueLevel3)
    {
        Debug.Log("Start talking");
        nametext.text = dialogueLevel3.name;
        kalimat.Clear();
        foreach(string kalimats in dialogueLevel3.kalimat)
        {
            kalimat.Enqueue(kalimats);
        }
        displaynext();

    }

    public void displaynext()
    {
        if (kalimat.Count == 0)
        {
            EndDialogue();  
            return;
        }
        string kalimats = kalimat.Dequeue();
        Dialogue.text = kalimats;
    }
    // Update is called once per frame
    void EndDialogue()
    {
        
        Debug.Log("END");
        //choice
        choicepanel.SetActive(true);
        dpanel.SetActive(false);
        
    }
}
