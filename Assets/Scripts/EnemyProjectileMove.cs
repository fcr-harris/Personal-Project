using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileMove : MonoBehaviour
{
    public float speed = 500f;
    public float bounds = 16f;
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
        if(transform.position.x > bounds){
            Destroy(gameObject);
        }
        if(transform.position.x < -bounds){
            Destroy(gameObject);
        }
    }
}
