using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanColour : MonoBehaviour
{
    SpriteRenderer cyanColour;

    // Start is called before the first frame update
    void Start()
    {
        cyanColour = GetComponent<SpriteRenderer>();
        cyanColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cyanColour.color = Color.cyan;
    }
}
