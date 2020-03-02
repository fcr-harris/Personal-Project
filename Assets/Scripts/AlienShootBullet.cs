using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShootBullet : MonoBehaviour
{
    private float shootDelay = 1.2f;
    public GameObject EnemyBullet;
    
    // Start is called before the first frame update
    void Start()
    {
        float shootInterval = Random.Range(1,2.3);
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
