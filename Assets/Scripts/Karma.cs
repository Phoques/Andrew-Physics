using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karma : MonoBehaviour
{
    public Image karmaBar;
    public float maxKarma = 1f;
    public float totalKarma;
    public float minusKarma = 0.25f;

    Advisors advisorsClass;

    private void Start()
    {
        totalKarma = 1f;
        advisorsClass = FindObjectOfType<Advisors>();
    }

    public void LoseKarma()
    {
        totalKarma = maxKarma -= minusKarma;

        karmaBar.fillAmount = totalKarma;

        if (totalKarma <= 0f)
        {
            advisorsClass.StartCoroutine(advisorsClass.ToHell());
        }
        
    }




}
