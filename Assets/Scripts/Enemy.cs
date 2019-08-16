using UnityEngine;
using System.Collections;

public class Enemy: MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _target;

    private float _currentSpeedY;
    private float _currentSpeedX;

    private Rigidbody2D rb2d;
    private Vector3 point;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        point = _target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _currentSpeedY = 0;
        _currentSpeedX = 0;

        point = _target.transform.position;


    }
    
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, point, Time.deltaTime * _speed);


          //  rb2d.velocity = new Vector2(Mathf.Lerp(0, _currentSpeedX, 0.8f),
          //                              Mathf.Lerp(0, _currentSpeedY, 0.8f));

    }

    void OnMouseDown()
    {
 
    }

}
