using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Lever : MonoBehaviour
{
    public GameObject door;
    
    

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door.activeInHierarchy == true)
        {
            door.SetActive(false);
            Debug.Log("Door Open");
        }   
        else if (door.activeInHierarchy == false)
        {
            door.SetActive(true);
            Debug.Log("Door Closed");
        }
    }
}
