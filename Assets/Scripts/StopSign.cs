using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSign : MonoBehaviour
{
    HingeJoint[] joints;
    public GameObject stopBlock;

    private void Start()
    {

        joints = GetComponentsInChildren<HingeJoint>();
    }


    public void MoveRail()
    {
        Debug.Log("Rail is MOVING");
        foreach (HingeJoint joint in joints)
        {

        JointMotor motor = joint.motor;
        motor.targetVelocity -= 35 * Time.deltaTime;
        motor.force += 15;
        joint.motor = motor;
        }
    }

   

}
