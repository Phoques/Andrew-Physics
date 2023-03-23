using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint3 : MonoBehaviour
{
    BoxCollider bc;
    Advisors advisorsClass;
    StopSign stopSignClass;


    private void Start()
    {
        advisorsClass = FindObjectOfType<Advisors>();
        bc = GetComponent<BoxCollider>();
        stopSignClass = FindObjectOfType<StopSign>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            stopSignClass.MoveRail();
            advisorsClass.StopAllCoroutines();
            advisorsClass.StartCoroutine(advisorsClass.Check3());
            bc.enabled = false;
        }
    }

    
}
