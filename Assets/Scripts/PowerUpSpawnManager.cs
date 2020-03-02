using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnManager : MonoBehaviour
{
    public GameObject powerUpPrefab;
    private float spawnPosX = 14;
    private float spawnRangeY = 4;
    private float spawnPosZ = 0;
    private float startDelay = 50;
    private float spawnInterval = 25;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerups",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPowerups(){
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangeY,spawnRangeY), spawnPosZ);
        Instantiate(powerUpPrefab, spawnPos, powerUpPrefab.transform.rotation);
    }
}
