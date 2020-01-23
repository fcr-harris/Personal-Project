using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien2ShootBullet : MonoBehaviour
{
    private float shootDelay = 1.2f;
    private float shootInterval = 1.3f;
    public GameObject EnemyBulletAlt;
    
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
        Instantiate(EnemyBulletAlt, transform.position, EnemyBulletAlt.transform.rotation);
    }
}
