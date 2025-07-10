using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloScript : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("action!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello " + name);
    }
    
}
