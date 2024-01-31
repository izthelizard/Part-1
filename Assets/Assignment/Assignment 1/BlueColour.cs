using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueColour : MonoBehaviour
{
    //set up for blue
    SpriteRenderer blueColour;

    // Start is called before the first frame update
    void Start()
    {
        //have it so the blue spot spawns in white
        blueColour = GetComponent<SpriteRenderer>();
        blueColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //have it so when the player moves into the circle it changes to blue
    private void OnTriggerEnter2D(Collider2D collision)
    {
        blueColour.color = Color.blue;
    }
}