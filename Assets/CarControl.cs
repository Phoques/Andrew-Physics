using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{

    HingeJoint[] joints;


    private void Start()
    {
        joints = GetComponentsInChildren<HingeJoint>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            foreach(HingeJoint joint in joints)
            {
                JointMotor motor = joint.motor;
                motor.targetVelocity += 200 * Time.deltaTime;
                joint.motor = motor;

               
            }

           
        }
    }




}
