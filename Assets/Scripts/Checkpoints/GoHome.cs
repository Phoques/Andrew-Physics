using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{

    Advisors advisorsClass;
    BoxCollider bc;

    private void Start()
    {
        advisorsClass = FindObjectOfType<Advisors>();
        bc = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }

    private void Update()
    {
        if (advisorsClass.badKarma)
        {
            bc.enabled= false;
        }
    }
}
