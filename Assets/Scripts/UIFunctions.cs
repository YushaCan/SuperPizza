using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIFunctions : MonoBehaviour
{
    public float time = 0f;
    public Animator gameOverAnimator;
    public void Restart()
    {
        Countdown.timeOfDelivery = 8;
        gameOverAnimator.SetBool("Active", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        gameOverAnimator.SetBool("Active", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
