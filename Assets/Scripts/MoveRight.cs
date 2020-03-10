using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 0.7f;

    // Update is called once per frame
    void Update()
    {
        //move
        transform.Translate(Vector3.down * speed);

        //destroy off screen
        float rightBound = 12.5f;

        if(transform.position.x > rightBound){
            Destroy(gameObject);
        }
    }

    
    
}
