using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMoveForward : MonoBehaviour
{
    public float speed = 0.12f;
    private float xRange = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed);

        float yPosition = transform.position.y;
        float zPosition = transform.position.z;

        if(transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, yPosition, zPosition);
        }
    }
}
