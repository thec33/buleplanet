using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMovement : MonoBehaviour
{
    public float movementSpeed;
    public GameObject shieldObject;
    public bool useDefaultControls = true; //use default controls?
    public KeyCode movementKey1;
    public KeyCode movementKey2;
    public KeyCode movementKey3;
    public KeyCode movementKey4;
    public KeyCode movementKey5;
    public KeyCode movementKey6;
    public int currentFace;
    public Material highlightMaterial;


    
    // Start is called before the first frame update YEAH AND
    void Start()
    {
        currentFace = 1;
    }

    // Update is called once per frame NOSH
    void Update()
    {
        assignMovementKeys();
        currentFaceUpdate();
        applyMovement();
    }

    public void assignMovementKeys()
    {
        if(useDefaultControls)
        {
            movementKey1 = KeyCode.S;
            movementKey2 = KeyCode.D;
            movementKey3 = KeyCode.F;
            movementKey4 = KeyCode.J;
            movementKey5 = KeyCode.K;
            movementKey6 = KeyCode.L;
        }
    }

    public  void applyMovement()
    {
        switch(currentFace)
        {
            case 1:
            
            transform.position = new Vector3(8,0, 0);
            transform.rotation = Quaternion.Euler(new Vector3(90, 90, 0));
            break;

            case 2:
            transform.position = new Vector3(0, 8, 0);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            break;

            case 3:
              transform.position = new Vector3(-8, 0, 0);
            transform.rotation = Quaternion.Euler(new Vector3(90, 90, 0));
            break;

            case 4:
            transform.position = new Vector3(0, -8, 0);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            break;

            case 5:
            transform.position = new Vector3(0, 0, -8);
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
            break;

            case 6:
            transform.position = new Vector3(0, 0, 8);
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
            break;
        }
    }

    public void currentFaceUpdate()
    {
        if(Input.GetKeyDown(movementKey1))
        {
            currentFace=1;
        }
        if(Input.GetKeyDown(movementKey2))
        {
            currentFace=2;
        }
        if(Input.GetKeyDown(movementKey3))
        {
            currentFace=3;
        }
        if(Input.GetKeyDown(movementKey4))
        {
            currentFace=4;
        }
        if(Input.GetKeyDown(movementKey5))
        {
            currentFace=5;
        }
        if(Input.GetKeyDown(movementKey6))
        {
            currentFace=6;
        }
    }

    public void OnTriggerEnter()
    {
        shieldObject.GetComponent<MeshRenderer>().material = highlightMaterial;
    }

}
