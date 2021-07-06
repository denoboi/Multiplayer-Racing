using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 15;
    private float horizontalInput;
    private float verticalInput;
    public Camera cam1;
    public Camera cam2;
    public string inputID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        

        //Move the vehicle forward 
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed) ;
        //rotate the vehicle 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }
       

    }
}
