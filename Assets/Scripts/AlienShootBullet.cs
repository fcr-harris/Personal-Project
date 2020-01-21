using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShootBullet : MonoBehaviour
{
    private float shootDelay = 1.2f;
    private float shootInterval = 1.3f;
    public GameObject EnemyBullet;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet",shootDelay,shootInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ShootBullet()
    {
        Instantiate(EnemyBullet, transform.position, EnemyBullet.transform.rotation);
    }
}
