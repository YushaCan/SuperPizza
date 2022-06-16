using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliverySpawner : MonoBehaviour
{
    public List<Slider> deliveryPoints;
    public List<GameObject> gameobjects;
    public List<GameObject> alarmLights;
    private int pickedMission;
    public float timeToSpawn;
    private bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if(timeToSpawn <= 0)
        {
            canSpawn = true;
            if (canSpawn && !GameOver.gameOver)
            {
                pickedMission = Random.Range(0, 32);
                gameobjects[pickedMission].gameObject.SetActive(true);
                deliveryPoints[pickedMission].gameObject.SetActive(true);
                alarmLights[pickedMission].gameObject.SetActive(true);
                canSpawn = false;
                // Decrease the time over score
                if (ScoreManager.score < 1000)
                {
                    timeToSpawn = 5;
                }
                if (ScoreManager.score > 1000 && ScoreManager.score < 3000)
                {
                    timeToSpawn = 4;
                }
                if (ScoreManager.score > 3000 && ScoreManager.score < 7000)
                {
                    timeToSpawn = 3;
                }
                if (ScoreManager.score > 7000 && ScoreManager.score < 10000)
                {
                    timeToSpawn = 2.75f;
                }
                if (ScoreManager.score > 10000)
                {
                    timeToSpawn = 2.5f;
                }
                
            }
        }
    }
}
