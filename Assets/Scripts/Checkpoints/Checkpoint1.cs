using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint1 : MonoBehaviour
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
            advisorsClass.StartCoroutine(advisorsClass.Check1());
            bc.enabled = false;
        }
    }
}
