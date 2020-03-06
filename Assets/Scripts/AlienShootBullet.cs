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
        InvokeRepeating("ShootBullet",shootDelay,Random.Range(1,3));
    }

    void ShootBullet()
    {
        Instantiate(EnemyBullet, transform.position, EnemyBullet.transform.rotation);
    }
}
