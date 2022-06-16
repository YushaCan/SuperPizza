using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableColliders : MonoBehaviour
{
    private BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerFly.isFlying)
        {
            boxCollider.enabled = false;
        }
        else
        {
            boxCollider.enabled = true;
        }
    }
}
