using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;

    public float delaySpawn = 2f;

    public float intervalSpawn = 1f;
    void Start()
    {
        InvokeRepeating("SpawnBullet", delaySpawn, intervalSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBullet()
    {
        Instantiate (bulletPrefab);
    }
}
