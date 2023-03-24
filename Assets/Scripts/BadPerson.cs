using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPerson : MonoBehaviour
{
    MeshCollider mc;
    MeshRenderer mr;

    private void Start()
    {
        mc= GetComponent<MeshCollider>();
        mr= GetComponent<MeshRenderer>();
    }


    public void RemoveFloor()
    {
        mr.enabled = false;
        mc.enabled = false;
    }



}
