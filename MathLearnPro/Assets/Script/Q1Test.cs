using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q1Test : MonoBehaviour
{
    public Rigidbody Body;
    public float UpForce = 5;
    public float ResisForce = 1.2f;
    public float GravityForce = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            Body.AddForce(Vector3.up * UpForce);
            Debug.Log("升力:"+Vector3.up* UpForce);
            Body.AddForce(Vector3.down * ResisForce);
            Debug.Log("浮力:" + Vector3.down * ResisForce);
            Body.AddForce(Vector3.down * GravityForce);
            Debug.Log("重力:" + Vector3.down * GravityForce);
        }
    }
}
