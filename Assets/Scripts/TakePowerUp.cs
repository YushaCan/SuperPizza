using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TakePowerUp : MonoBehaviour
{
    public Image imageUI;
    public GameObject light;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            light.gameObject.SetActive(false);
            imageUI.gameObject.SetActive(false);
            imageUI.gameObject.GetComponent<InactivatePowerUp>().timeForPickup = 12;
        }
    }
}
