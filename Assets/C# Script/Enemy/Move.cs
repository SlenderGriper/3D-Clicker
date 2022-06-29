using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody _controller;
    [SerializeField] private float _speed;
    private int _vectorDirection;
    void Start()
    {
        _controller = GetComponent<Rigidbody>();
        if (this.transform.position.x < 0) _vectorDirection = 1;
        else _vectorDirection = -1;
    }

    void FixedUpdate()
    {
        Vector3 forceVector = new Vector3(_speed*_vectorDirection, 0, 0);
        _controller.AddForce(forceVector);
    }
    private void OnCollisionEnter(Collision collision)
    {
        ChangeDirection(collision.gameObject.tag);
    }
    private void ChangeDirection(string wall)
    {
        if (wall == "wall")
        {
            _vectorDirection *= -1;
            Vector3 forceVector = new Vector3(_speed * _vectorDirection, -1, 0);
            _controller.AddForce(forceVector, ForceMode.Impulse);
        }
    }
}
