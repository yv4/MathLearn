using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q5TestDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(this.transform.position, this.transform.position + (this.transform.forward * 5), Color.blue);
    }
}
