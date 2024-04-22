using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q5Test : MonoBehaviour
{
    // Start is called before the first frame updat

    public Transform ProjectObj;

    private float m_Distance = 0;

    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.D))
        {
            Vector3 dir = ProjectObj.transform.forward;
            dir.Normalize();
            m_Distance = Vector3.Dot(this.transform.forward,dir);
            Debug.Log("Check:"+ m_Distance);
        }

        Debug.DrawLine(this.transform.position, this.transform.forward * m_Distance*3, Color.red);
    }
}
