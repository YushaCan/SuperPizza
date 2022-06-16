using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaysOneTime : MonoBehaviour
{
    public static int isActive = 0;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        isActive++;
        audioSource = GetComponent<AudioSource>();
        if (isActive > 1)
        {
            //audioSource.playOnAwake = false;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
