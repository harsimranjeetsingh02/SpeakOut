using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInformation : MonoBehaviour
{

    public GameObject title;

    public Text textFile;

    public TextAsset text;
    public string[] textlines;

    public int currentLine;

    public int endAtLine;
    // Start is called before the first frame update
    void Start()
    {
        if (textFile != null)
        {
            textlines = (textFile.text.Split('\n'));

        }
        if(endAtLine == 0)
        {
            endAtLine = textlines.Length - 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        textFile.text = textlines[currentLine];
    }
}
