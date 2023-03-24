using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam0;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    private void Start()
    {
        cam0.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }

    private void Update()
    {
        
        ChangeCamera();
    }

    private void ChangeCamera()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            KillCamera();
            cam0.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            KillCamera();
            cam1.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            KillCamera();
            cam2.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            KillCamera();
            cam3.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            KillCamera();
            cam4.SetActive(true);
        }
    }

    private void KillCamera()
    {
        cam0.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }

}
