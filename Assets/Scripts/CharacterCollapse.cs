using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollapse : MonoBehaviour
{
    //Joint[] joints;
    Rigidbody[] rbs;
    Karma karmaClass;


    private void Start()
    {


        //joints = GetComponentsInChildren<HingeJoint>();
        rbs = GetComponentsInChildren<Rigidbody>();
        karmaClass = FindObjectOfType<Karma>();

        //This is setting all of the rigidbodies in the Ragdoll we created on the object to Kinematic (Meaning they wont collapse or move like normal rigid body)
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = true;
            CollisionDetect collisionDetect = rb.gameObject.AddComponent<CollisionDetect>();
            collisionDetect.characterCollapse = this;
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            FallOver();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            GoStiff();
        }


    }

    public void FallOver()
    {
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = false;
        }
            karmaClass.LoseKarma();
    }

    public void GoStiff()
    {
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = true;
        }
    }

}
