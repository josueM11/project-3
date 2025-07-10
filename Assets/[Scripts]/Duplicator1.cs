using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator1 : MonoBehaviour
{
    public GameObject part;

    public Transform spawnPart;



    


    

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Instantiate(part, spawnPart.position, spawnPart.rotation);
    }
}
