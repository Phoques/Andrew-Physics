using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    private void Start()
    {
        Application.targetFrameRate = 1000;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void FrameRateUnlimited()
    {
            Application.targetFrameRate = 1000;
    }

    public void FrameRate60()
    {
        Application.targetFrameRate = 60;
    }

    public void FrameRate30()
    {
        Application.targetFrameRate = 30;
    }

    public void Greybox()
    {
        SceneManager.LoadScene(4);
    }


}
