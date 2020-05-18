using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;


public class GameEngine : MonoBehaviour
{
    public Text barText = null;
    static void Main()
    {
        string title = "";
        double nodenumber;
        string decisionone = "";
        double onetonode;
        string decisiontwo = "";
        double twotonode;
        string decisionthree = "";
        double threetonode;
        string decisionfour = "";
        double fourtonode;

        using (StreamReader reader = new StreamReader("Good Morning! 0001.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                title = reader.ReadLine();
                nodenumber = Convert.ToDouble(reader.ReadLine());
                string[] decansone = line.Split('|');
                decisionone = Convert.ToString(decansone[0]);
                onetonode = Convert.ToDouble(decansone[1]);
                string[] decanstwo = line.Split('|');
                decisiontwo = Convert.ToString(decanstwo[0]);
                twotonode = Convert.ToDouble(decanstwo[1]);
                string[] decansthree = line.Split('|');
                decisionthree = Convert.ToString(decansthree[0]);
                threetonode = Convert.ToDouble(decansthree[1]);
                string[] decansfour = line.Split('|');
                decisionfour = Convert.ToString(decansfour[0]);
                fourtonode = Convert.ToDouble(decansfour[1]);
                double correctdecision = Convert.ToDouble(reader.ReadLine());
            }
        }
    }
}
