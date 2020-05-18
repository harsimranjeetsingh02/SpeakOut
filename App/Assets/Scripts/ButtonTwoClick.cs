using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ButtonTwoClick : MonoBehaviour
{
    //Be able to conect these to actual scene
    public Text barText;
    public Text descriptiontext = null;
    public Text decisionone = null;
    public Text decisiontwo = null;
    public Text decisionthree = null;
    public Text decisionfour = null;
    // Start is called before the first frame update

    Texture2D image;


    public void TwoButtonClick()
    {
        //accecssing the variables for decision texts for the buttons (public)
        /*string OneText = NewGameEngine.DecisionOne;
        string TwoText = NewGameEngine.DecisionTwo;
        string ThreeText = NewGameEngine.DecisionThree;
        string FourText = NewGameEngine.DecisionFour;*/
        //accessing tonode variables for which node the decisions go to from NewGameEngine.cs
        string decisionOneNode = NewGameEngine.OneToNode;
        string decisionTwoNode = NewGameEngine.TwoToNode;
        string decisionThreeNode = NewGameEngine.ThreeToNode;
        string decisionFourNode = NewGameEngine.FourToNode;

        //ReadTextfile that decision one went to
        using (StreamReader reader = new StreamReader("Assets//Resources//" + decisionTwoNode + ".txt"))
        {
            string line;
            //Assign variables as text is read from file
            string title = reader.ReadLine();
            string onNode = Convert.ToString(reader.ReadLine());
            string description = reader.ReadLine();
            string decisiononetext = reader.ReadLine();
            string oneToNode = Convert.ToString(reader.ReadLine());
            string decisiontwotext = reader.ReadLine();
            string twoToNode = Convert.ToString(reader.ReadLine());
            string decisionthreetext = reader.ReadLine();
            string threeToNode = Convert.ToString(reader.ReadLine());
            string decisionfourtext = reader.ReadLine();
            string fourToNode = Convert.ToString(reader.ReadLine());
            string correctnode = Convert.ToString(reader.ReadLine());
            string imagename = Convert.ToString(reader.ReadLine());

            //update the text to show for each button after reading textfile
            NewGameEngine.DecisionOne = decisiononetext;
            NewGameEngine.DecisionTwo = decisiontwotext;
            NewGameEngine.DecisionThree = decisionthreetext;
            NewGameEngine.DecisionFour = decisionfourtext;
            //update public tonode variables to what is being read from textfile
            NewGameEngine.OneToNode = oneToNode;
            NewGameEngine.TwoToNode = twoToNode;
            NewGameEngine.ThreeToNode = threeToNode;
            NewGameEngine.FourToNode = fourToNode;

            //Change it in the scene
            barText.text = title;
            descriptiontext.text = description;
            decisionone.text = decisiononetext;
            decisiontwo.text = decisiontwotext;
            decisionthree.text = decisionthreetext;
            decisionfour.text = decisionfourtext;

            image = Resources.Load("Images/"+imagename) as Texture2D;
            GameObject rawImage = GameObject.Find("RawImage");
            rawImage.GetComponent<RawImage>().texture = image;

        }
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
