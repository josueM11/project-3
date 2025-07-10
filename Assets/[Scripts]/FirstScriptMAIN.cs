using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public string name;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Action");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello " + name);
    }
}
