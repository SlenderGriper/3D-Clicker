using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyPrefab;
    [SerializeField] private GameObject _menuController;
    private float _spawnSpeed;
    private float _defficulty;
    private bool _freezeSpawn;
    private float _timeFreeze;
    void Start()
    {
        _spawnSpeed = 2;
        _defficulty = 1;
        _timeFreeze = 3;
        _freezeSpawn = false;
        StartCoroutine(Creator());
    }
    public void FreezeSpawn(float timeFreeze)
    {
        _freezeSpawn = true;
        _timeFreeze = timeFreeze;
    }
    IEnumerator Creator()
    {
        
        while (TextChanger.current.NeedMoreEnemy)
        {
            yield return new WaitForSeconds(_spawnSpeed);
            if(_freezeSpawn) yield return new WaitForSeconds(_timeFreeze);
            Creator(out GameObject enemy,out Vector3 spawnLocated);
            TextChanger.current.ChangeTextEnemy(1);

            enemy = Instantiate(enemy, spawnLocated, transform.rotation);
            PreparingEnemy(enemy);    
        }
        _menuController.GetComponent<Score>().AddList();
        _menuController.GetComponent<Scene>().DeathMenu();
    }
    public void IncreaseDefficulty(float multiplier)
    {
        _defficulty *= multiplier;
    }
    public void DecreaseSpawnSpeed(float multiplier)
    {
        _spawnSpeed /= multiplier;
    }
    private void Creator(out GameObject enemy, out Vector3 spawnLocated)
    {
        int i;
        float x, z;
        i = Random.Range(0, _enemyPrefab.Length);
        x = Random.Range(-12f, 12f);
        z = Random.Range(-2f, 2f);
        enemy = _enemyPrefab[i];
        spawnLocated = new Vector3(x, 0.5f, z);
    }

    private void PreparingEnemy(GameObject enemy)
    {
        enemy.GetComponent<StatsChanger>().СhangeStats(_defficulty);
        enemy.GetComponent<Transform>().parent = this.gameObject.GetComponent<Transform>();
    }
}


