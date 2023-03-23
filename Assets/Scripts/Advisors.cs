using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Advisors : MonoBehaviour
{
    public Text angelText;
    public Text devilText;


    public IEnumerator Check1()
    {
        Debug.Log("Checkpoint 1 triggered");

        angelText.text = "Hello, I am your guidance for all that is good.";
        devilText.text = "Im the one who makes things fun, so dont listen to the other guy.";

        yield return new WaitForSeconds(8);

        angelText.text = "Its best you dont move forward, its late and you should go home";
        devilText.text = "";

        yield return new WaitForSeconds(5);

        devilText.text = "Nah, stuff that, drive forward and break into the factory!";

        yield return new WaitForSeconds(5);

        angelText.text = "";
        devilText.text = "";
    }

    public IEnumerator Check2()
    {
        Debug.Log("Checkpoint 2 triggered");

        angelText.text = "No! Why did you do that?";
        devilText.text = "HAHA YES! Now go to that Stop Sign";

        yield return new WaitForSeconds(2);
        angelText.text = "";

        yield return null;
    }

    public IEnumerator Check3()
    {
        Debug.Log("Checkpoint 3 triggered");

        angelText.text = "Those workers seem busy with some sort of heavy machinery, we should turn back";
        yield return new WaitForSeconds(4);
        devilText.text = "No way! Beep your horn and give em a scare haha!";

    }

}
