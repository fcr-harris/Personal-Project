using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    private float spawnPosX = 14;
    private float spawnRangeY = 4;
    private float spawnPosZ = 0;
    private float startDelay = 5;
    private float spawnInterval = 2.3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAliens",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAliens()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangeY,spawnRangeY), spawnPosZ);
        int alienIndex = Random.Range(0, alienPrefabs.Length);
        Instantiate(alienPrefabs[alienIndex], spawnPos, alienPrefabs[alienIndex].transform.rotation);
    }
}
