using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnManager : MonoBehaviour
{
    public GameObject alien;
    public GameObject powerup;
    public int enemyCount;
    public int waveNumber = 1;
    public float spawnPosX = 15;
    public float spawnRangePowerupY = 4;
    public float spawnDelay = 25;
    public float spawnInterval = 35f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerUp", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       enemyCount = FindObjectsOfType<AlienDetectCollisions>().Length;
            if (enemyCount == 0){
                waveNumber ++;
                SpawnEnemyWave(waveNumber);
            }
       
    }

    void SpawnPowerUp()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangePowerupY,spawnRangePowerupY),0);
        Instantiate(powerup,spawnPos,powerup.transform.rotation);
    }
    
    Vector3 GenerateSpawnPosition()
    {
        float spawnRangeY = Random.Range(-4,4);

        Vector3 randomPos = new Vector3(spawnPosX,spawnRangeY,0);

        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn){
        for (int i = 0; i < enemiesToSpawn; i++){
            Instantiate(alien,GenerateSpawnPosition(),alien.transform.rotation);
        }
    }
}
