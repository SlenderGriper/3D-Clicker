using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class StatsChanger : MonoBehaviour,IPointerClickHandler
{
    
    [SerializeField] private float _hp;
    [SerializeField] private float _score;
   
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _hp--;
        if (_hp <= 0)
        {
            Dead();
        }
    }
    public void Dead()
    {
        TextChanger.current.ChangeTextEnemy(-1);
        TextChanger.current.ChangeTextScore(_score);
        Destroy(gameObject);
    }
    public void СhangeStats(float multiplier)
    {
        _hp*= multiplier;
        _score *= multiplier;
    }

}

