using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerFly : MonoBehaviour
{
    public Slider powerupSlider;
    public PlayerMovement playerMovement;
    private Transform playerTransform;
    public static bool canFly;
    public static bool isFlying;
    public float gravityModifier;
    private float flyingPos;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        flyingPos = 1f;
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (powerupSlider.value > 0 && Input.GetKey(KeyCode.Space) && canFly && !GameOver.gameOver)
        {
            //flyEnergy -= Time.deltaTime;
            powerupSlider.value -= Time.deltaTime;
            //Speed Boost
            playerMovement.forwardSpeed = 5.6f;
            playerMovement.backSpeed = 0f;
            playerMovement.turningAbility = 8;
            // Transform update
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, flyingPos, transform.position.z); 
            //
            isFlying = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space) || !canFly && !GameOver.gameOver)
        {         
            playerMovement.forwardSpeed = 2.8f;
            playerMovement.backSpeed = 0.8f;
            playerMovement.turningAbility = 4;
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x, landingPos, transform.position.z);
            isFlying = false;
        }

        if(powerupSlider.value <= 0)
        {
            canFly = false;
        }
        else{
            canFly = true;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            // Increase the fly energy by half seconds.
            if(powerupSlider.value < 5)
            {
                powerupSlider.value += 0.5f;
            }       
        }
    }
}
