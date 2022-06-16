using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public Slider countdownSlider;
    public GameObject alarmLight;
    public static int timeOfDelivery = 8;
    // Start is called before the first frame update
    void Start()
    {
        countdownSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        countdownSlider.value -= Time.deltaTime;
        if (countdownSlider.value <= 0 && !GameOver.gameOver)
        {
            gameObject.SetActive(false);
            alarmLight.gameObject.SetActive(false);
            countdownSlider.maxValue = timeOfDelivery;
            countdownSlider.value = timeOfDelivery;
            // LOSE HEALTH
            GameOver.healths--;
            GameOver.loseHealth = true;
        }
        if(ScoreManager.score > 2000 && ScoreManager.score < 5000)
        {
            timeOfDelivery = 6;
        }
        if (ScoreManager.score > 5000 && ScoreManager.score < 10000)
        {
            timeOfDelivery = 5;
        }
        if (ScoreManager.score > 10000 && ScoreManager.score < 20000)
        {
            timeOfDelivery = 4;
        }
        if (ScoreManager.score > 20000)
        {
            timeOfDelivery = 3;
        }
    }
}
