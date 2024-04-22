using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q10Test : MonoBehaviour
{
    public float ViewAngle = 70;
    public float ViewRadius = 10;
    public GameObject Player;
    private Vector3 CheckLeftVec;
    private Vector3 CheckRightVec;

    // Start is called before the first frame update
    void Start()
    {
        CheckLeftVec = Quaternion.Euler(0, -(ViewAngle / 2), 0) * transform.forward*ViewRadius;

        CheckRightVec = Quaternion.Euler(0, (ViewAngle / 2), 0) * transform.forward * ViewRadius;

    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, CheckLeftVec, Color.red);
        Debug.DrawRay(this.transform.position, CheckRightVec, Color.red);

        if(Input.GetKeyDown(KeyCode.D))
        {
            Vector3 playerDir =  Player.transform.position-this.transform.position;
            float currentDis = playerDir.magnitude;

            float currentAngle = Vector3.Angle(playerDir, this.transform.forward);
            float apiangle = Vector3.Angle(CheckLeftVec, CheckRightVec);
            Debug.Log("Api Angle:" + apiangle);
            Debug.Log("Current Angle:" + currentAngle);
            Debug.Log("Current Distance:" + currentDis);

            if(currentAngle<apiangle&&currentDis<ViewRadius)
            {
                Debug.Log("View");
            }
            else
            {
                Debug.Log("No View");
            }
        }

    }
}
