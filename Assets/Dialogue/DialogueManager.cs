using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> kalimat;
    public Text nametext;
    public Text Dialogue;
    public GameObject dpanel;

    // Start is called before the first frame update
    void Start()
    {
        kalimat = new Queue<string>();
    }

    public void StarDialogue(Dialogue dialogue)
    {
        Debug.Log("Start talking");
        nametext.text = Dialogue.name;
        kalimat.Clear();
        foreach(string kalimats in dialogue.kalimat)
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
        dpanel.SetActive(false);

    }
}
