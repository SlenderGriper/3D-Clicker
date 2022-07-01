using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class FreezeSpawnEnemy : MonoBehaviour, IPointerClickHandler
{
    private Transform _enemyFather;
    private void Start()
    {
        _enemyFather = GetComponent<Transform>().parent.GetComponent<Transform>();
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        _enemyFather.GetComponent<Spawn>().FreezeSpawn(3f);
        Destroy(gameObject);
    }
}
