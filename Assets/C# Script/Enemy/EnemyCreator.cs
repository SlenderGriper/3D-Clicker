using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject fastEnemyPrefab;
    public GameObject enemyPrefab;
    public GameObject tankEnemyPrefab;
    void Start()
    {
       StartCoroutine(Creator());
    }
    IEnumerator Creator()
    {
        int i = 0;
        float x, z;
        yield return new WaitForSeconds(4);
        while (i<=100)
        {
            x = Random.Range(-12f, 12f);
            z = Random.Range(-2f, 2f);
            var spawnLocated = new Vector3(x, 0.5f, z);
            Instantiate(enemyPrefab,spawnLocated, transform.rotation);
            yield return new WaitForSeconds(1);
            i++;
        }
        }
    }


