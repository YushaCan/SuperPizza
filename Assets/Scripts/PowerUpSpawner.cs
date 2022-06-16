using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUpSpawner : MonoBehaviour
{
    public List<Image> powerUpImages;
    public List<GameObject> powerUpGOs;
    public List<GameObject> light;
    private int randomSpawnPoint;
    public float timeToSpawn;
    private bool canSpawn;

    private void Start()
    {
        timeToSpawn = 4;
    }
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if(timeToSpawn <= 0)
        {
            canSpawn = true;
            if (canSpawn && !GameOver.gameOver)
            {
                randomSpawnPoint = Random.Range(0, 10);
                powerUpImages[randomSpawnPoint].gameObject.SetActive(true);
                powerUpGOs[randomSpawnPoint].gameObject.SetActive(true);
                light[randomSpawnPoint].gameObject.SetActive(true);
                canSpawn = false;
                // Decrease over score
                if (ScoreManager.score < 2000)
                {
                    timeToSpawn = 7;
                }
                if (ScoreManager.score > 2000 && ScoreManager.score < 5000)
                {
                    timeToSpawn = 6;
                }
                if (ScoreManager.score > 5000 && ScoreManager.score < 10000)
                {
                    timeToSpawn = 5;
                }
                if (ScoreManager.score > 10000 && ScoreManager.score < 20000)
                {
                    timeToSpawn = 4.75f;
                }
                if (ScoreManager.score > 20000)
                {
                    timeToSpawn = 4.5f;
                }
                
            }
        }
    }
}
