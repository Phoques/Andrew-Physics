using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint3 : MonoBehaviour
{
    BoxCollider bc;
    Advisors advisorsClass;


    private void Start()
    {
        advisorsClass = FindObjectOfType<Advisors>();
        bc = GetComponent<BoxCollider>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            advisorsClass.StopAllCoroutines();
            advisorsClass.StartCoroutine(advisorsClass.Check3());
            bc.enabled = false;
        }
        
    }

    
}
