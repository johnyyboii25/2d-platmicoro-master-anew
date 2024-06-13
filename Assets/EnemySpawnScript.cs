using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject Enemy;
    public float SpawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnEnemy();
            timer = 0;
        }
    }

    void spawnEnemy()
    {
        Instantiate(Enemy, transform.position , transform.rotation);
    }
}
