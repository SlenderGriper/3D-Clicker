using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class EnemyPattern : MonoBehaviour,IPointerClickHandler
{
    [SerializeField] private double _speed;
    [SerializeField] private double _hp;
    private Rigidbody _controller;
    void Start()
    {
        _controller = GetComponent<Rigidbody>();
        
    }
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _hp--;
        if(_hp<=0) Destroy(gameObject);
    }
}

