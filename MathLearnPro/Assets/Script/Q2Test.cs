using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q2Test : MonoBehaviour
{
    public Rigidbody Player;

    public float Speed = 5;
    public float RunTimer = 0;
    public float RunMaxTime = 5;

    private bool m_IsRun = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            m_IsRun = true;
            Debug.Log("起始位置:" + transform.position);
            Vector3 checkPos = this.transform.position + (Vector3.right * Speed * RunMaxTime);
            Debug.Log("计算位置:" + checkPos);
        }

        if(m_IsRun)
        {
            if(RunTimer<RunMaxTime)
            {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
                RunTimer += Time.deltaTime;
            }
            else
            {
                Debug.Log("结束位置:" + transform.position);
                m_IsRun = false;
            }
        }
     
    }
}
