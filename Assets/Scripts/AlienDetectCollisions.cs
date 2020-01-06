using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienDetectCollisions : MonoBehaviour
{
    public float Health = 3;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player Projectile(Clone)"){
            Health = Health - 1;
            Destroy(other.gameObject);
        }

       if(Health <= 0){
           Destroy(gameObject);
       }

    }
}
