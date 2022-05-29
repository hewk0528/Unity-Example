using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin;
    public float spawnRateMax;

    float spawnRate = 0.0f;
    Transform target;
    float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0.0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<Controller_Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0.0f;

            GameObject bullet;
            bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            bullet.transform.LookAt(target);
        }
    }
}
