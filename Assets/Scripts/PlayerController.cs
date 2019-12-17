using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.17f;
    private float xRange = 11.4f;
    private float yRange = 4.4f;
    private float horizontalInput;
    private float verticalInput;
    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput);
        transform.Translate(Vector3.up * speed * verticalInput);
        
        //Keep this loser inbounds
        float xPosition = transform.position.x;
        float yPosition = transform.position.y;
        float zPosition = transform.position.z;

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, yPosition, zPosition);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, yPosition, zPosition);
        }
        if(transform.position.y < -yRange)
        {
            transform.position = new Vector3(xPosition, -yRange, zPosition);
        }
        if(transform.position.y > yRange)
        {
            transform.position = new Vector3(xPosition, yRange, zPosition);
        }
        
        //Create projectile on player input (spacebar)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
