using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //movement speed
    public float speed = 0.17f;
    //bounds
    private float xRange = 11.4f;
    private float yRange = 4.4f;
    //input
    private float horizontalInput;
    private float verticalInput;
    //projectiles, powerup indicator
    public GameObject projectilePrefab;
    public GameObject projectilePrefabAlt;
    public GameObject powerupIndicator;
    //power up
    public bool hasPowerUp = false;
    public bool powerupActive = false;
    //how many hits the player can take
    public float playerLives = 3;

    // Update is called once per frame
    void Update()
    {
        //destroy player when out of lives
        if(playerLives <= 0){
            Destroy(gameObject);
        }
        //Player movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput);
        transform.Translate(Vector3.up * speed * verticalInput);
        //keep powerup indicator on the player
        powerupIndicator.transform.position = transform.position;
        
        //Keep this loser inbounds
        float xPosition = transform.position.x;
        float yPosition = transform.position.y;
        float zPosition = transform.position.z;

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, yPosition, zPosition);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, yPosition, zPosition);
        }
        if(transform.position.y < -yRange)
        {
            transform.position = new Vector3(xPosition, -yRange, zPosition);
        }
        if(transform.position.y > yRange)
        {
            transform.position = new Vector3(xPosition, yRange, zPosition);
        }

        //Button to activate powerup (Q)

        if (Input.GetKeyDown(KeyCode.Q) && hasPowerUp == true){
            powerupIndicator.gameObject.SetActive(false);
            powerupActive = true;
            StartCoroutine(PowerupCountdownRoutine());
        }
        
        //Create projectile on player input (spacebar)
        if (Input.GetKeyDown(KeyCode.Space) && powerupActive == false)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space) && powerupActive == true)
        {
            Instantiate(projectilePrefabAlt, transform.position, projectilePrefab.transform.rotation);
        }
    }
    
    void OnTriggerEnter(Collider other){
        //give powerup on collision with it
        if(other.gameObject.name == "PowerUp(Clone)" && hasPowerUp == false){
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            hasPowerUp = true;
        }
        //detect collisions with enemy bullets, subtract lives
        if(other.gameObject.name == "Enemy Projectile(Clone)"){
            playerLives -= 1;
            Destroy(other.gameObject);
        }
    }
    //powerup countdown
     IEnumerator PowerupCountdownRoutine(){
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerupActive = false;
    }
}
