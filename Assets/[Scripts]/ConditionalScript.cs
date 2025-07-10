using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalScript : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        bool answer1 = true && false;
        bool answer2 = (9 < 3) || (100 < 45);
        bool another1 = ((3439 > 40) && (1 < 3)) || answer1;
        bool another2 = !(1 + 1 == 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
