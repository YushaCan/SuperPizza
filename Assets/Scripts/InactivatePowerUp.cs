using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactivatePowerUp : MonoBehaviour
{
    public float timeForPickup;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        timeForPickup = 12;
    }

    // Update is called once per frame
    void Update()
    {
        timeForPickup -= Time.deltaTime;
        if(timeForPickup <= 0 && !GameOver.gameOver)
        {
            gameObject.SetActive(false);
            light.gameObject.SetActive(false);
            timeForPickup = 12;
        }
    }
}
