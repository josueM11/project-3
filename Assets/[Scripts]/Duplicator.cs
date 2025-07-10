using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour
{
    public GameObject Capsule;

    public Transform spawn;

    public float Timer;

    

    
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    public IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Timer);
            Instantiate(Capsule, spawn.position, spawn.rotation);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
