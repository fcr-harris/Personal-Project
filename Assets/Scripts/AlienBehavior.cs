using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBehavior : MonoBehaviour
{
    //movement variables
    public float speed = 0.12f;
    private float xRange = 6f;

    //detect collision variables
    public float Health = 3;

    //bullet firing variables
    private float shootDelay = 1.2f;
    public GameObject EnemyBullet;

    //player variable
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //find player
        player = GameObject.Find("Player");
        //invoke shoot once in position at varied intervals
        InvokeRepeating("ShootBullet",shootDelay,Random.Range(0.5f,2.5f));
    }

    // Update is called once per frame
    void Update()
    {
        //move into and stop at position
        transform.Translate(Vector3.left * speed);

        float yPosition = transform.position.y;
        float zPosition = transform.position.z;

        if(transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, yPosition, zPosition);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //subtract health when hit by a bullet
        if(other.gameObject.name == "Player Projectile(Clone)"){
            Health -= 1;
            Destroy(other.gameObject);
        }
        //powerup bullets destroy alien instantly
        if(other.gameObject.name == "Player Projectile Powered(Clone)"){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        //destroy alien with 0 health
        if(Health <= 0){
           Destroy(gameObject);
        }

    }
    //shoot.
    void ShootBullet()
    {
        Instantiate(EnemyBullet, transform.position, EnemyBullet.transform.rotation);
    }
}
