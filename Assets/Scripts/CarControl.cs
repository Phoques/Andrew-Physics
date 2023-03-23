using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{

    HingeJoint[] joints;
    public float wheelTurn;
    public bool blowHorn;
    //public GameObject frontWheelLeft;


    private void Start()
    {
        joints = GetComponentsInChildren<HingeJoint>();
        
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            blowHorn = true;
            Debug.Log("Blow Horn");
        }
        else if(Input.GetMouseButtonUp(0))
        {
            blowHorn = false;
            Debug.Log("NO Horn");
        }
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            foreach (HingeJoint joint in joints)
            {
                JointMotor motor = joint.motor;
                motor.targetVelocity -= 200 * Time.deltaTime;
                joint.motor = motor;


            }


        }

        if (Input.GetKey(KeyCode.S))
        {
            foreach (HingeJoint joint in joints)
            {
                JointMotor motor = joint.motor;
                motor.targetVelocity += 500 * Time.deltaTime;
                joint.motor = motor;


            }
        }

        //Good for rotating an object that doesnt use gravity.
        /*if (Input.GetKey(KeyCode.D))
        {
            //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
            m_EulerAngleVelocity = new Vector3(0, 500, 0);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

        }

        if (Input.GetKey(KeyCode.A))
        {
            //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
            m_EulerAngleVelocity = new Vector3(0, -500, 0);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }*/

        

        

    }

    


}
