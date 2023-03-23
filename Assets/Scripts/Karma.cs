using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karma : MonoBehaviour
{
    public Image karmaBar;
    public float maxKarma = 1f;
    public float minKarma = 0f;
    public float totalKarma;
    public float minusKarma = 0.25f;
    

    public void LoseKarma()
    {
        totalKarma = maxKarma -= minusKarma;

        karmaBar.fillAmount = totalKarma;
        
    }



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            LoseKarma();
        }
    }

}
