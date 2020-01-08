using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Enemy Projectile(Clone)"){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
