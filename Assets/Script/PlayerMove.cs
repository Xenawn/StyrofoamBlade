using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float _moveSpeed = 3.5f;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        float _Xhor = Input.GetAxis("Horizontal");
        float _Yver = Input.GetAxis("Vertical");
        //Vector2 _moveDirection = new Vector2(_Xhor, _Yver);
        //transform.Translate(_moveDirection*_moveSpeed*Time.deltaTime);
        _rb.linearVelocity = new Vector2(_Xhor * _moveSpeed, _Yver * _moveSpeed);

    }
}
