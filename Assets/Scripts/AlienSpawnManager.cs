using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
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
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
        int alienIndex = Random.Range(0, alienPrefabs.Length);
        Instantiate(alienPrefabs[alienIndex], new Vector3(0,0,20),alienPrefabs[alienIndex].transform.rotation);
    }
}
