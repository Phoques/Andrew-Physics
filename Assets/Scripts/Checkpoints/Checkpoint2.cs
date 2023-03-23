using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    BoxCollider bc;
    Advisors advisorsClass;
    Karma karma;


    private void Start()
    {
        advisorsClass = FindObjectOfType<Advisors>();
        bc = GetComponent<BoxCollider>();
        karma = FindObjectOfType<Karma>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            advisorsClass.StopAllCoroutines();
            karma.LoseKarma();
            advisorsClass.StartCoroutine(advisorsClass.Check2());
            bc.enabled = false;
        }
    }
}
