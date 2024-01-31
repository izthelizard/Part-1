using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSplat : MonoBehaviour
{
    //set up for the moving object
    Rigidbody2D paintSplat;
    //speed set
    float speed = 20f;

    // Start is called before the first frame update
    private void Start()
    {
        paintSplat = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        //movement of the paintsplat object
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
}
