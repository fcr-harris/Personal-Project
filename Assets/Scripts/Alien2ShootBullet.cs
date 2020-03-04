using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien2ShootBullet : MonoBehaviour
{

    //https://www.youtube.com/watch?v=NivKaNN7I00 this is a 2d tutorial? but might be helpful as a starting point

    private float shootDelay = 1.2f;
    private float shootInterval = 0.8f;
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
