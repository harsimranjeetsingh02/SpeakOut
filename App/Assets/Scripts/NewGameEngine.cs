using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class NewGameEngine : MonoBehaviour
{
    
    //Connecting the UI to the code
    public Text barText;
    public Text descriptiontext = null;
    public Text decisionone = null;
    public Text decisiontwo = null;
    public Text decisionthree = null;
    public Text decisionfour = null;
    Texture2D image;
    //public variables for the decision texts and the nodes/screens they go to
    public static string DecisionOne = null;
    public static string DecisionTwo = null;
    public static string DecisionThree = null;
    public static string DecisionFour = null;

    public static string OneToNode;
    public static string TwoToNode;
    public static string ThreeToNode;
    public static string FourToNode;

    void Start()
    {
        //Iterating through textfiles
        using (StreamReader reader = new StreamReader("Assets//Resources//0001.txt.txt"))
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

            //Change public variables for text and the node that they go to
            DecisionOne = decisiononetext;
            OneToNode = oneToNode;
            DecisionTwo = decisiontwotext;
            TwoToNode = twoToNode;
            DecisionThree = decisionthreetext;
            ThreeToNode = threeToNode;
            DecisionFour = decisionfourtext;
            FourToNode = fourToNode;
            image = Resources.Load("Images/GoodMorning") as Texture2D;

            GameObject rawImage = GameObject.Find("RawImage");
            rawImage.GetComponent<RawImage> ().texture = image;

            //Change the values of the UI in the actual scene
            barText.text = title;
            descriptiontext.text = description;
            decisionone.text = DecisionOne;
            decisiontwo.text = DecisionTwo;
            decisionthree.text = DecisionThree;
            decisionfour.text = DecisionFour;
        }
    }
}
