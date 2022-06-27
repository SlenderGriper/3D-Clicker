using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefab;
    void Start()
    {
       StartCoroutine(Creator());
    }
    IEnumerator Creator()
    {
        int i;
        float x, z;
        yield return new WaitForSeconds(4);
        while (TextChanger.current.NeedMoreEnemy)
        {
            i = Random.Range(0, enemyPrefab.Length);
            x = Random.Range(-12f, 12f);
            z = Random.Range(-2f, 2f);
            var spawnLocated = new Vector3(x, 0.5f, z);
            TextChanger.current.ChangeTextEnemy(1);
            Instantiate(enemyPrefab[i],spawnLocated, transform.rotation);
            yield return new WaitForSeconds(1);
        }
        }
    }


