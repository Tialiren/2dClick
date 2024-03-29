﻿using UnityEngine;
using System.Collections;



public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private KeyCode _upKey;
    [SerializeField] private KeyCode _downKey;
    [SerializeField] private KeyCode _leftKey;
    [SerializeField] private KeyCode _rightKey;

    private float _currentSpeedY;
    private float _currentSpeedX;

    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _currentSpeedY = 0;
        _currentSpeedX = 0;


        if (Input.GetKey(_downKey))
            _currentSpeedY = -_speed;

        if (Input.GetKey(_upKey))
            _currentSpeedY = _speed;

        if (Input.GetKey(_leftKey))
            _currentSpeedX = -_speed;

        if (Input.GetKey(_rightKey))
            _currentSpeedX = _speed;

    }
    
    private void FixedUpdate()
    {
        //transform.position = Vector3.Lerp(transform.position,
          //  new Vector3(transform.position.x + _currentSpeedX, transform.position.y + _currentSpeedY), Time.deltaTime);


            rb2d.velocity = new Vector2(Mathf.Lerp(0, _currentSpeedX, 0.8f),
                                        Mathf.Lerp(0, _currentSpeedY, 0.8f));

    }

    void OnMouseDown()
    {
 
    }

}
