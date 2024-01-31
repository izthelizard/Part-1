using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowColour : MonoBehaviour
{
    //set up for yellow
    SpriteRenderer yellowColour;

    // Start is called before the first frame update
    void Start()
    {
        //have it so the yellow spot spawns in white
        yellowColour = GetComponent<SpriteRenderer>();
        yellowColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //have it so when the player moves into the circle it changes to yellow
    private void OnTriggerEnter2D(Collider2D collision)
    {
        yellowColour.color = Color.yellow; 
    }
}