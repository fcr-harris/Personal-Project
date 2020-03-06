using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.17f;
    private float xRange = 11.4f;
    private float yRange = 4.4f;
    private float horizontalInput;
    private float verticalInput;
    public GameObject projectilePrefab;
    public GameObject projectilePrefabAlt;
    public GameObject powerupIndicator;
    public bool hasPowerUp = false;
    public bool powerupActive = false;

    // Update is called once per frame
    void Update()
    {
        //Player movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput);
        transform.Translate(Vector3.up * speed * verticalInput);

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

        //Button to activate powerup

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
        if(other.gameObject.name == "PowerUp(Clone)" && hasPowerUp == false){
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            hasPowerUp = true;
        }
    }
     IEnumerator PowerupCountdownRoutine(){
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerupActive = false;
    }
}
