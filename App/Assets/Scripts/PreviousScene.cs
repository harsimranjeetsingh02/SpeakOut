using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousScene : MonoBehaviour
{
    //Going to previous screen
   public void previousscene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
