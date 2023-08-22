using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTimer = 1f;
    [SerializeField] int PoolSize = 5;
    GameObject[] Pool;

    void Awake()
    {
        populatePool();
    }

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
     void populatePool()
     {
        Pool = new GameObject[PoolSize];
        for (int i = 0; i < Pool.Length; i++)
        {
            Pool[i] = Instantiate(enemyPrefab, transform);
           
            Pool[i].SetActive(false);
        }
     }

    void EnableObjectInPool()
    {
        for (int i = 0; i < Pool.Length; i++)
        {
            if (Pool[i].activeInHierarchy == false)
            {
                Pool[i].SetActive(true);
                return;
            }
        }
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(spawnTimer);
        }
    }

}
