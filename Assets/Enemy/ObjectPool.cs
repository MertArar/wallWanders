  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTimer = 1f;  
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    
    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            Instantiate(enemyPrefab, transform);
            yield return new WaitForSeconds(spawnTimer);
        }
    }
}
