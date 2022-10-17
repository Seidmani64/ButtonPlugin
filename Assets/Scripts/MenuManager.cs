using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button button;
    public Button button2;
    public enum ButtonFunction {Select, Swap}
    public ButtonFunction selectedFunction = ButtonFunction.Select;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(FirstTask);
        button2.onClick.AddListener(SecondTask);
    }

    void FirstTask()
    {
        switch(selectedFunction)
        {
            case ButtonFunction.Select:
                Debug.Log("Button 1 Selected.");
                break;
            case ButtonFunction.Swap:
                button.gameObject.SetActive(false);
                button2.gameObject.SetActive(true);
                break;
        }
        
    }

    void SecondTask()
    {
        switch(selectedFunction)
        {
            case ButtonFunction.Select:
                Debug.Log("Button 2 Selected.");
                break;
            case ButtonFunction.Swap:
                button.gameObject.SetActive(true);
                button2.gameObject.SetActive(false);
                break;
        }
        
    }
}
