using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class CCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        using (StreamReader reader = new StreamReader(@"Decisions (SUB FILE #1).txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line == "*" || line == "")
                {
                    continue;
                }
                if (line == "DECISIONS")
                {
                    reader.ReadLine();
                    string[] terms = line.Split('|');

                    string decisionnum = Convert.ToString(terms[0]);
                    string decision = Convert.ToString(terms[1]);
                    double outcome = Convert.ToDouble(terms[2]);
                    reader.ReadLine();
                }

                if(line == "TITLE")
                {
                    reader.ReadLine();
                    string title = Convert.ToString(reader.ReadLine());
                    reader.ReadLine();
                }
                if(line == "QUESTION")
                {
                    reader.ReadLine();
                    string question = Convert.ToString(reader.ReadLine());
                    reader.ReadLine();
                }

                if(line == "MESSAGE")
                {
                    reader.ReadLine();
                    string message = Convert.ToString(reader.ReadLine());
                    reader.ReadLine();
                }

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
