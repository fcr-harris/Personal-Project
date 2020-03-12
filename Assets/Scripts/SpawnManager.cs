using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //prefabs
    public GameObject alien;
    public GameObject powerup;
    //count enemies and waves
    public int enemyCount;
    public int waveNumber = 1;
    //spawn positions
    public float spawnPosX = 15;
    public float spawnRangePowerupY = 4;
    //spawn time
    public float spawnDelay = 25;
    public float spawnInterval = 35f;
    // Start is called before the first frame update
    void Start()
    {
        //spawn powerups after 25 seconds every 35 seconds
        InvokeRepeating("SpawnPowerUp", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if all enemies are destroyed, spawn next wave
        enemyCount = FindObjectsOfType<AlienBehavior>().Length;
            if (enemyCount == 0){
                waveNumber ++;
                SpawnEnemyWave(waveNumber);
            }
       
    }
    //generate powerup spawn position and spawn powerup
    void SpawnPowerUp()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangePowerupY,spawnRangePowerupY),0);
        Instantiate(powerup,spawnPos,powerup.transform.rotation);
    }
    //generate enemy spawn positions
    Vector3 GenerateSpawnPosition()
    {
        float spawnRangeY = Random.Range(-4,4);

        Vector3 randomPos = new Vector3(spawnPosX,spawnRangeY,0);

        return randomPos;
    }
    //enemy spawn loop
    void SpawnEnemyWave(int enemiesToSpawn){
        for (int i = 0; i < enemiesToSpawn; i++){
            Instantiate(alien,GenerateSpawnPosition(),alien.transform.rotation);
        }
    }
}
