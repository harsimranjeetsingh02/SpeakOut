using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FadeAndLoadScene : MonoBehaviour
{
    public string sceneToLoad;
    public Image fade;
    public Animator anim;
    public float delay; // 0f, 1f 4.5f

    void Start()
    {
        StartCoroutine(FadeAndLoad());
    }
    IEnumerator FadeAndLoad()
    {
        yield return new WaitForSeconds(delay);
        anim.SetTrigger("out");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
