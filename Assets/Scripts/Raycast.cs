using UnityEngine;

public class Raycast : MonoBehaviour
{

    CarControl carControlClass;
    StopSign stopSignClass;
    Advisors advisorsClass;
    WreckingBall wreckingBallClass;
    RaycastHit hit;
    


    void Start()
    {
        carControlClass = FindObjectOfType<CarControl>();
        stopSignClass = FindObjectOfType<StopSign>();
        advisorsClass= FindObjectOfType<Advisors>();
        wreckingBallClass = FindObjectOfType<WreckingBall>();
    }




    void Update()
    {

        StopSignCast();
    }

    public void StopSignCast()
    {

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5f))
        {
            if (hit.collider.tag == "Stop Sign" && carControlClass.blowHorn)
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.blue);
                stopSignClass.MoveRail();
                Destroy(stopSignClass.stopBlock);
                advisorsClass.StopAllCoroutines();
                advisorsClass.StartCoroutine(advisorsClass.WorkerDeath());
                wreckingBallClass.WreckingBallGo();


            }


        }
    }

}
