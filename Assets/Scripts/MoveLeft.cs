using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move left, destroy when outside of the left boundary
        transform.Translate(speed * Time.deltaTime * Vector3.left);
        
        float leftBound = -16f;
        if(transform.position.x < leftBound){
            Destroy(gameObject);
        }
    }
    
}