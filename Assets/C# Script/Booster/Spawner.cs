using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _boosterPrefab;
    void Start()
    {
        StartCoroutine(Creator());
    }
    IEnumerator Creator()
    {
        float spawnSpeed;
        while (TextChanger.current.NeedMoreEnemy)
        {
            spawnSpeed = Random.Range(5f,20f);
            yield return new WaitForSeconds(spawnSpeed);
            Creator(out GameObject booster, out Vector3 spawnLocated);
            booster = Instantiate(booster, spawnLocated, transform.rotation);
            booster.GetComponent<Transform>().parent = this.gameObject.GetComponent<Transform>();
        }
    }
    private void Creator(out GameObject booster, out Vector3 spawnLocated)
    {
        int i;
        float x, z;
        i = Random.Range(0, _boosterPrefab.Length);
        x = Random.Range(-12f, 12f);
        z = Random.Range(-2f, 2f);
        booster = _boosterPrefab[i];
       
        spawnLocated = new Vector3(x, 0.5f, z);
    }
}
