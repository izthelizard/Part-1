using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColour : MonoBehaviour
{
    //set up for red
    SpriteRenderer redColour;

    // Start is called before the first frame update
    void Start()
    {
        //have it so the red spot spawns in white
        redColour = GetComponent<SpriteRenderer>();
        redColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //have it so when the player moves into the circle it changes to red
    private void OnTriggerEnter2D(Collider2D collision)
    {
        redColour.color = Color.red;
    }
}
