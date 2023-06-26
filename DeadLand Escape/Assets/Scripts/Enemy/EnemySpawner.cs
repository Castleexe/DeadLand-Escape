using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject zombiePrefab;

    int wave = 1;
    int totalEnemies;
    int enemiesSpawned = 0;

    float spawnWaitTime = 2.8f;
    float spawnMinTime = 0.15f;
    float spawnDecrement = 0.25f;
    bool enemyCanSpawn = true;


    // Start is called before the first frame update
    void Start()
    {
        totalEnemies = Random.Range((wave * 10), (wave * 10 + 10));
    }

    // Update is called once per frame
    void Update()
    {
        spawnWave();
    }

    void setVariables()
    {
        totalEnemies = Random.Range((wave * 20), (wave * 20 + 10));
        if(spawnWaitTime > spawnMinTime)
        {
            spawnWaitTime -= spawnDecrement;
        }
        wave++;
        Debug.Log(wave);
    }

    void spawnWave()
    {
        if (totalEnemies > enemiesSpawned)
        {
            spawnEnemy();
        }
        else
        {  
            setVariables();
        }
    }
 
    void spawnEnemy()
    {
        if (enemyCanSpawn == true)
        {
            for (int i = 0; i < Random.Range(1, 4); i++)
            {
                Instantiate(zombiePrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
            }
            StartCoroutine(enemySpawn());

            enemiesSpawned++;
        }
    }

    IEnumerator enemySpawn()
    {
        enemyCanSpawn = false;
        yield return new WaitForSeconds(spawnWaitTime);
        enemyCanSpawn = true;
    }
}
