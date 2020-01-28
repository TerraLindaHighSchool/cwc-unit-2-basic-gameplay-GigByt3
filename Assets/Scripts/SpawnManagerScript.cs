using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject[] animals;
    public int spawnPosZ;
    public int spawnRange;
    public float startDelay;
    public float spawnInterval;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnRangomAnimal", startDelay, spawnInterval);
    }

    void SpawnRangomAnimal()
    {
    	int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);

    }
}
