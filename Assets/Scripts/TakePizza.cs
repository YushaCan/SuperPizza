using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TakePizza : MonoBehaviour
{
    public Image pizzaImage;
    public GameObject greenLight;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            pizzaImage.gameObject.SetActive(false);
            greenLight.gameObject.SetActive(false);
            pizzaImage.GetComponent<InactivatePizzaSlices>().timeToPickUp = 5;
            GameOver.gainHealth = true;
            GameOver.healths++;
        }
    }
}
