using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAllEnemy : MonoBehaviour
{
    [SerializeField]  private Transform _enemyParents;
    void Start()
    {
        foreach(Transform child in _enemyParents)
        {
            child.GetComponent<StatsChanger>()?.Dead();
        }
    }

}
