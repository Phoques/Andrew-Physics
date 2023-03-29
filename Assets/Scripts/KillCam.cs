using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCam : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject machineCam;
    public GameObject killCam;


    private void Start()
    {
        machineCam.SetActive(false);
        killCam.SetActive(false);
    }

    public IEnumerator KillCamera()
    {
        mainCam.SetActive(false);
        machineCam.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        machineCam.SetActive(false);
        killCam.SetActive(true);
        yield return new WaitForSeconds(2);
        killCam.SetActive(false);
        mainCam.SetActive(true);
    }


}
