using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UtilityLibraries;

public class PluginUse : MonoBehaviour
{
    public int n1 = 1;
    public int n2 = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PluginTest.sum(n1,n2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
