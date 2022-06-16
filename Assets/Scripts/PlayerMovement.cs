using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float forwardSpeed;
    public float backSpeed;
    public float turningAbility;

    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        // For mouse being unvisible
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && !GameOver.gameOver)
        {
            isMoving = true;
            transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
        }
        else if (Input.GetKey(KeyCode.S) && !GameOver.gameOver)
        {
            isMoving = true;
            transform.Translate(-Vector3.forward * Time.deltaTime * backSpeed);
        }
        
       
        if (Input.GetKey(KeyCode.A) && isMoving && !GameOver.gameOver)
        {
            transform.Rotate(-Vector3.up, turningAbility);
        }
        else if (Input.GetKey(KeyCode.D) && isMoving && !GameOver.gameOver)
        {
            transform.Rotate(Vector3.up, turningAbility);
        }

    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W) && !GameOver.gameOver)
        {
            isMoving = false;
        }
        else if (Input.GetKeyUp(KeyCode.S) && !GameOver.gameOver)
        {
            isMoving = false;
        }
    }
}

