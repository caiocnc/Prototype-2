using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    // Define o tempo de spawn entre um animal e outro
    void Start() => InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);

    // Update is called once per frame
    void Update()
    {
               
    }

    //Sistema de Spawn Rand�mico
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}