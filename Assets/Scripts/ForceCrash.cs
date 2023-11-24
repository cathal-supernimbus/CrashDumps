using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCrash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0;i<10;i++)
            Debug.Log(i);
        UnityEngine.Diagnostics.Utils.ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory.FatalError);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
