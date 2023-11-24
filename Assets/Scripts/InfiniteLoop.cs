using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i--)
        {
            i = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
