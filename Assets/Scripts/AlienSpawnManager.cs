using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnManager : MonoBehaviour
{
    public GameObject alien;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {

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
    
    Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = 15;
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
