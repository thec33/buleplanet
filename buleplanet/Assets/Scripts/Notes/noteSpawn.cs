using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteSpawn : MonoBehaviour
{
    public GameObject note;
    public int spawnSide = 5;
    public float noteSpeed = 10f;
    public Transform target;
    public bool isMoving = true;
    public GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        


        transform.LookAt(target);//look at the BULE planet

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            generateNote();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        if (isMoving == true)
        {
            moveNote();
        }
    }

    void generateNote()
    {
        clone = Object.Instantiate(note, transform.position, transform.rotation); //instantiate note and assign it to clone
    }
    void moveNote()
    {
        clone.transform.Translate(Vector3.forward * noteSpeed * Time.deltaTime); // Slide the note towards BULE planet
    }

    private void OnTriggerEnter(Collider other) //detect shield hit
    {
        
        Destroy(note); // destroy the note
    }
}
