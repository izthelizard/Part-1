using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagentaColour : MonoBehaviour
{
    //set up for magenta
    SpriteRenderer magentaColour;

    // Start is called before the first frame update
    void Start()
    {
        //have it so the magenta spot spawns in white
        magentaColour = GetComponent<SpriteRenderer>();
        magentaColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //have it so when the player moves into the circle it changes to magenta
    private void OnTriggerEnter2D(Collider2D collision)
    {
        magentaColour.color = Color.magenta;
    }
}