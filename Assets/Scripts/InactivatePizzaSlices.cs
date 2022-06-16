using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactivatePizzaSlices : MonoBehaviour
{
    public float timeToPickUp;
    public GameObject greenLight;
    // Start is called before the first frame update
    void Start()
    {
        timeToPickUp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timeToPickUp -= Time.deltaTime;
        if(timeToPickUp <= 0 && !GameOver.gameOver)
        {
            gameObject.SetActive(false);
            greenLight.gameObject.SetActive(false);
            timeToPickUp = 5;
        }
    }
}
