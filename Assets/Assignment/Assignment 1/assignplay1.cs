using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignplay1 : MonoBehaviour
{
    //setup
    //vector to use movement
    Vector2 direction;
    //assigned rigidbody2D to be able to use and function in code
    public Rigidbody2D rigbodyassigment1;
    //added force of movement
    public float force = 150f;

    // Start is called before the first frame update
    private void Start()
    {
        //made player use the component rididbody2D to envoke physics
        rigbodyassigment1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //have the WASD/arrow keys move the player
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        //added movement force/physics to move the player around
        rigbodyassigment1.AddForce(direction * force * Time.deltaTime);
    }
}
