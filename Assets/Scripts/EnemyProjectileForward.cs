﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileForward : MonoBehaviour
{
    public float speed = 10f;
    public float leftBound = -13f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("EnemyBulletAlt")){
            
            transform.Translate((Vector3.left + Vector3.up) * Time.deltaTime * (speed+2));
        }

        transform.Translate(Vector3.left * Time.deltaTime * speed);

         if(transform.position.x < leftBound){
            Destroy(gameObject);
        }
    }
}
