using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Advisors : MonoBehaviour
{
    public Text angelText;
    public Text devilText;
    public Text securityText;
    public Text workerText;
    public Text jerryText;
    public Text helpText;
    public Text announcementText;

    public bool badKarma;


    BadPerson badPersonClass;


    private void Start()
    {
        badPersonClass = FindObjectOfType<BadPerson>();
    }

    public IEnumerator Check1()
    {
        Debug.Log("Checkpoint 1 triggered");

        angelText.text = "Hello, I am your guidance for all that is good.";
        yield return new WaitForSeconds(2);
        devilText.text = "Im the one who makes things fun, so dont listen to the other guy.";

        yield return new WaitForSeconds(8);

        angelText.text = "Dont go into the Factory ahead, its late and you should go home";
        devilText.text = "";

        yield return new WaitForSeconds(5);

        
        devilText.text = "Dont listen to him, drive forward and break into the factory!";
        helpText.text = "Use WSAD to drive the car";

        yield return new WaitForSeconds(5);

        angelText.text = "";
        devilText.text = "";
    }

    public IEnumerator Check2()
    {
        Debug.Log("Checkpoint 2 triggered");

        helpText.text = "";
        angelText.text = "No! Why did you do that?";
        devilText.text = "HAHA YES!";

        yield return new WaitForSeconds(4);
        angelText.text = "";
        devilText.text = "";

        yield return null;
    }

    public IEnumerator Check3()
    {
        Debug.Log("Checkpoint 3 triggered");

        securityText.text = "HEY! Stop right there Pal!";
        angelText.text = "Those workers seem busy with some sort of heavy machinery, we should turn back";
        yield return new WaitForSeconds(8);
        devilText.text = "No way! Beep your horn and give em a scare hahaha!";
        yield return new WaitForSeconds(4);
        angelText.text = "";
        devilText.text = "";

        helpText.text = "Press left mouse click to use horn";

    }

    public IEnumerator CheckGood()
    {
        helpText.text = "";
        Debug.Log("Checkpoint Good triggered");
        devilText.text = "";
        angelText.text = "You're almost home, now be careful around the pedestrians!";
        yield return new WaitForSeconds(4);
        devilText.text = "MOW THEM DOWN!";


    }


    public IEnumerator WorkerDeath()
    {
        helpText.text = "";
        angelText.text = "No, why!?";
        devilText.text = "Gooooood";
        jerryText.text = "NO! AHHHHHH!";
        yield return new WaitForSeconds(2);
        workerText.text = "Jerry No! He was 1 day from retirement!";
        securityText.text = "You monster!";

        yield return new WaitForSeconds(8);
        workerText.text = "";
        securityText.text = "";
        jerryText.text = "";
        devilText.text = "AAAAHAHAHAHAHAHAHA!";



    }

    public IEnumerator ToHell()
    {
        badKarma = true;
        announcementText.text = "You caused someones death, your karma has decided to send you to Hell!";
        yield return new WaitForSeconds(10);

        badPersonClass.RemoveFloor();

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(3);
    }

}
