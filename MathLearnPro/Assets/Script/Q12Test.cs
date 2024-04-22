using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q12Test : MonoBehaviour
{
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = this.transform.position - Target.transform.position;

        Vector3 checkVec = Vector3.Cross(dir, Target.transform.forward);

   
        if(checkVec.y> 0)
        {
            Debug.Log("Left");
        }
        else
        {
            Debug.Log("Right");
        }
    }
}
