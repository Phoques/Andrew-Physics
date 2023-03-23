using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    CarControl carControlClass;
    StopSign stopSignClass;
    RaycastHit hit;
    public bool raycastHit = false;


    void Start()
    {
        carControlClass = FindObjectOfType<CarControl>();
        stopSignClass = FindObjectOfType<StopSign>();
    }

    private void RayCasting()
    {


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {

            raycastHit = true;

            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.blue);
            Debug.Log("Did Hit");


        }
        else
        {
            raycastHit = false;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.green);
            Debug.Log("Did not Hit");
        }
    }


    void Update()
    {
        RayCasting();
        StopSignCast();
    }

    public void StopSignCast() // Need to probably make this a trigger or something instead. raycast iosnt working
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10f) && carControlClass.blowHorn)
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.black);
            if (gameObject.transform.tag == "StopSign")
            {
                stopSignClass.MoveRail();

            }


        }
    }

}
