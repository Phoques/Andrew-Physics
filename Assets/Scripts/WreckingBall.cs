using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBall : MonoBehaviour
{
    Rigidbody[] rbs;

    private void Start()
    {
        rbs = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = true;
        }
    }



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            WreckingBallGo();
        }
    }


    public void WreckingBallGo()
    {
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = false;
        }
    }


}
