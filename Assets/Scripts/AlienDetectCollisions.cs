using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienDetectCollisions : MonoBehaviour
{
    public float Health = 5;

    void Start(){
        if(gameObject.name == "Alien"){
            Health -= 2;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player Projectile(Clone)"){
            Health -= 1;
            Destroy(other.gameObject);
        }

        if(other.gameObject.name == "Player Projectile Powered(Clone)"){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

       if(Health <= 0){
           Destroy(gameObject);
       }

    }
}
