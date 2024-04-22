using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q6Test : MonoBehaviour
{
    public Rigidbody Player;
    public Transform ReflectObj;

    private Vector3 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        moveDir = this.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.D))
        {
           
            Vector3 enterDir = this.transform.forward * 5;

            float nDistance = Vector3.Dot((-1 * enterDir), ReflectObj.transform.forward);

            Vector3 normalDir = ReflectObj.transform.forward.normalized * nDistance;

            Vector3 halfDVector = enterDir + normalDir;

            Vector3 dVector = 2 * halfDVector;

            Vector3 reflectVector = dVector = dVector - enterDir;

            moveDir = reflectVector;
            Debug.Log("check");

           
        }
        else
        {
            Player.velocity=moveDir;
        }
    }
}
