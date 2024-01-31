using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColour : MonoBehaviour
{
    SpriteRenderer redColour;

    // Start is called before the first frame update
    void Start()
    {
        redColour = GetComponent<SpriteRenderer>();
        redColour.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        redColour.color = Color.red;
    }
}
