using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenColour : MonoBehaviour
{
    SpriteRenderer greenColour;

    // Start is called before the first frame update
    void Start()
    {
        greenColour = GetComponent<SpriteRenderer>();
        greenColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        greenColour.color = Color.green;
    }
}