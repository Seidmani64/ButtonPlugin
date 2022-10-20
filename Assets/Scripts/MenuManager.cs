using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

[ExecuteInEditMode]
public class MenuManager : MonoBehaviour
{
    public enum ButtonFunction {Select, Swap}
    [System.Serializable]
    public struct MenuButton {
     public Button button;
     public ButtonFunction function;
     public Button swapButton;
                            }
    [SerializeField]
    public List<MenuButton> menuButtons;

    // Start is called before the first frame update
    void Start()
    {
        if(menuButtons.Count > 0)
            foreach(MenuButton mb in menuButtons)
            {
                if(mb.function == ButtonFunction.Select)
                    mb.button.onClick.AddListener(delegate {Task(mb.button);});
                else if(mb.swapButton == null)
                    mb.button.onClick.AddListener(delegate {Task(mb.button, mb.button);});
                else
                    mb.button.onClick.AddListener(delegate {Task(mb.button, mb.swapButton);});
                    
            }
        
    }

    void Task(Button b)
    {
        TextMeshProUGUI tmp = b.GetComponentInChildren<TextMeshProUGUI>();
        Debug.Log(tmp.text + " Selected.");
    }

    void Task(Button b, Button b2)
    {
        b.gameObject.SetActive(false);
        b2.gameObject.SetActive(true);
        
    }
}
