using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSign : MonoBehaviour
{
    HingeJoint[] joints;
    CarControl carControlClass;

    private void Start()
    {

        joints = GetComponentsInChildren<HingeJoint>();
        carControlClass = FindObjectOfType<CarControl>();
    }

    private void Update()
    {
        
        
    }

    public void MoveRail()
    {
        foreach (HingeJoint joint in joints)
        {

        JointMotor motor = joint.motor;
        motor.targetVelocity -= 25 * Time.deltaTime;
        motor.force += 15;
        joint.motor = motor;
        }
    }

   

}
