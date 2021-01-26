using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueLevel3 
{
    // Start is called before the first frame update
    public string name;

    [TextArea(3, 10)]
    public string[] kalimat;
}
