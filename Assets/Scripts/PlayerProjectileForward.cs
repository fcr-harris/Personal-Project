using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileForward : MonoBehaviour
{
    public float speed = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move
        transform.Translate(Vector3.down * speed);

        //destroy off screen
        float rightBound = 12.5f;

        if(transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
    
}
