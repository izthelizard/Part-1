using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenColour : MonoBehaviour
{
    //set up for green
    SpriteRenderer greenColour;

    // Start is called before the first frame update
    void Start()
    {
        //have it so the green spot spawns in white
        greenColour = GetComponent<SpriteRenderer>();
        greenColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //have it so when the player moves into the circle it changes to green
    private void OnTriggerEnter2D(Collider2D collision)
    {
        greenColour.color = Color.green;
    }
}