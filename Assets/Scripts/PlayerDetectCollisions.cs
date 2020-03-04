using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectCollisions : MonoBehaviour
{
    public float playerLives = 3;
    public bool hasPowerUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLives <= 0){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Enemy Projectile(Clone)"){
            playerLives -= 1;
            Destroy(other.gameObject);
        }

        if(other.gameObject.name == "PowerUp(Clone)"){
            Destroy(other.gameObject);
            hasPowerUp = true;
        }
    }
}
