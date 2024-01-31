using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSwitch : MonoBehaviour
{
    //set up for the switch
    public GameObject paintSplatPrefab;
    public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //made so when player runs into the object it activates the prefab
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //position so that the paintsplat prefab spawns off screen
        Instantiate(paintSplatPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
}