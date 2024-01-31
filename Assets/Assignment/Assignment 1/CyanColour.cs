using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanColour : MonoBehaviour
{
    //set up for cyan
    SpriteRenderer cyanColour;

    // Start is called before the first frame update
    void Start()
    {
        //have it so the cyan spot spawns in white
        cyanColour = GetComponent<SpriteRenderer>();
        cyanColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //have it so when the player moves into the circle it changes to cyan
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cyanColour.color = Color.cyan;
    }
}
