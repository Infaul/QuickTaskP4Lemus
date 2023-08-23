using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float yRange = 10.0f;

    public float zMin;
    public float zMax;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.x);
        }
        if(transform.position.x < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if (transform.position.x > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);

        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
