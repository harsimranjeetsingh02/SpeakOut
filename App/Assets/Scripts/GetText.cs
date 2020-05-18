using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetText : MonoBehaviour
{
    Button button;
    public GameObject inputfield;
    public GameObject canvas;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        GameObject newInputField = Instantiate(inputfield) as GameObject;
        newInputField.transform.SetParent(newInputField.transform, false);



    }

}
