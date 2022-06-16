using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeliverPizza : MonoBehaviour
{
    public Slider missionSlider;
    private int sliderScore;
    public GameObject alarmLight;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Convert float to int
            sliderScore = Mathf.FloorToInt(missionSlider.value);
            // Update Total Score
            ScoreManager.score += (sliderScore * 75);
            gameObject.SetActive(false);
            missionSlider.gameObject.SetActive(false);
            alarmLight.gameObject.SetActive(false);
            missionSlider.maxValue = Countdown.timeOfDelivery;
            missionSlider.value = Countdown.timeOfDelivery;
        }
    }
}
