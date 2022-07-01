using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DeleteAllEnemy : MonoBehaviour, IPointerClickHandler
{
    private Transform _enemyFather;
    private void Start()
    {
        _enemyFather = GetComponent<Transform>().parent.GetComponent<Transform>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        foreach(Transform child in _enemyFather)
        {
            child.GetComponent<StatsChanger>()?.Dead();
        }
        Destroy(gameObject);
    }

}
