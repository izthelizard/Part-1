using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagentaColour : MonoBehaviour
{
    SpriteRenderer magentaColour;

    // Start is called before the first frame update
    void Start()
    {
        magentaColour = GetComponent<SpriteRenderer>();
        magentaColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        magentaColour.color = Color.magenta;
    }
}