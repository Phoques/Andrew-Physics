using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRate : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 1000;
    }
}
