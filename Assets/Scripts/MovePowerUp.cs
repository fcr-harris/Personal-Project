using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePowerUp : MonoBehaviour
{
    public float speed = 10f;
    public float leftBound = -16f;
    private Rigidbody bulletRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        Vector3 moveDirection = (player.transform.position - transform.position).normalized;
        bulletRb.AddForce(moveDirection * speed);
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.x < leftBound){
            Destroy(gameObject);
         }
         if(transform.position.x < -leftBound){
            Destroy(gameObject);
        }
    }
    
}