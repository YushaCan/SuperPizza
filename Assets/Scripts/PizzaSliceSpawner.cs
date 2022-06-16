using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PizzaSliceSpawner : MonoBehaviour
{
    public List<Image> pizzaSliceImages;
    public List<GameObject> pizzaSlicesGos;
    public List<GameObject> lights;
    private int randomSpawnNumber;
    public float timeToSpawn;
    private bool canSpawn;

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if(timeToSpawn <= 0)
        {
            canSpawn = true;
            if (canSpawn && GameOver.healths < 3 && !GameOver.gameOver)
            {
                randomSpawnNumber = Random.Range(0, 3);
                pizzaSliceImages[randomSpawnNumber].gameObject.SetActive(true);
                pizzaSlicesGos[randomSpawnNumber].gameObject.SetActive(true);
                lights[randomSpawnNumber].gameObject.SetActive(true);
                canSpawn = false;
                // Decrease over score
                if(ScoreManager.score < 2000)
                {
                    timeToSpawn = 20;
                }
                if (ScoreManager.score > 2000 && ScoreManager.score < 5000)
                {
                    timeToSpawn = 18;
                }
                if (ScoreManager.score > 5000 && ScoreManager.score < 10000)
                {
                    timeToSpawn = 16;
                }
                if (ScoreManager.score > 10000 && ScoreManager.score < 20000)
                {
                    timeToSpawn = 13;
                }
                if (ScoreManager.score > 20000)
                {
                    timeToSpawn = 12;
                }


            }
        }
    }
}
