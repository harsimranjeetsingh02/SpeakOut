using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ButtonOneClick : MonoBehaviour
{

    //Connect UI to Code
    public Text barText;
    public Text descriptiontext = null;
    public Text decisionone = null;
    public Text decisiontwo = null;
    public Text decisionthree = null;
    public Text decisionfour = null;
    Texture2D image;
    public void OneButtonClick()
    {
        //Accessing variables that hold the values of the decisions that were created in GameEngine.cs that will be used
        string decisionOneNode = NewGameEngine.OneToNode;
        string decisionTwoNode = NewGameEngine.TwoToNode;
        string decisionThreeNode = NewGameEngine.ThreeToNode;
        string decisionFourNode = NewGameEngine.FourToNode;

        //Read the textfile which the decision leads to
        using (StreamReader reader = new StreamReader("Assets//Resources//" + decisionOneNode + ".txt"))
        {
            string line;
            //Store text-file values to variables as text is read from file
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

            //update decisions for the next screen
            NewGameEngine.DecisionOne = decisiononetext;
            NewGameEngine.DecisionTwo = decisiontwotext;
            NewGameEngine.DecisionThree = decisionthreetext;
            NewGameEngine.DecisionFour = decisionfourtext;

            //update the values of each decision for the next screen
            NewGameEngine.OneToNode = oneToNode;
            NewGameEngine.TwoToNode = twoToNode;
            NewGameEngine.ThreeToNode = threeToNode;
            NewGameEngine.FourToNode = fourToNode;

            //Update the UI to show the next screen
            barText.text = title;
            descriptiontext.text = description;
            decisionone.text = decisiononetext;
            decisiontwo.text = decisiontwotext;
            decisionthree.text = decisionthreetext;
            decisionfour.text = decisionfourtext;

            image = Resources.Load("Images/" + imagename) as Texture2D;
            GameObject rawImage = GameObject.Find("RawImage");
            rawImage.GetComponent<RawImage>().texture = image;
        }
    }
}
