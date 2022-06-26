using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private float _speed = 0.05f;
    float _x;
    void Update()
    {
        if(Input.touchCount > 0){
            var touch = Input.GetTouch(0);
            Debug.Log("sss");
            
            if (touch.phase == TouchPhase.Moved)
            {
                _x = transform.position.x;
                _x -= touch.deltaPosition.x*_speed;
                if (_x < -10) _x = -10;
                else if (_x > 10) _x = 10;
                transform.position = new Vector3(_x, transform.position.y, transform.position.z);
            }
        }
    }
}
