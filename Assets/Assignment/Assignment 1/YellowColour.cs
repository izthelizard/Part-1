using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowColour : MonoBehaviour
{
    SpriteRenderer yellowColour;

    // Start is called before the first frame update
    void Start()
    {
        yellowColour = GetComponent<SpriteRenderer>();
        yellowColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        yellowColour.color = Color.yellow; 
    }
}