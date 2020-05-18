using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuProfile : MonoBehaviour
{
    //Change the screen
    public void changemenuscreen(string scenename)
    {
        SceneManager.LoadScene(scenename);

    }
}
