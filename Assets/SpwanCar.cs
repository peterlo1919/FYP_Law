using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanCar : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject cars;

    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCar", spawnTime, spawnTime);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnCar()
    {

        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(cars, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}
