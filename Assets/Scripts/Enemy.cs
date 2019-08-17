using UnityEngine;
using UnityEngine.Tilemaps;
public class Enemy: MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject target;
    [SerializeField] private Grid grid;
    [SerializeField] private Tilemap plane;
    [SerializeField] private Tilemap obstacles;

    private float currentSpeedY;
    private float currentSpeedX;

    private Rigidbody2D rb2d;
    private Vector3 point;
    

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Use this for initialization
    void Start()
    {
        PathGrid _pathGrin = new PathGrid(plane, obstacles, transform.position, target.transform.position);



    }

    // Update is called once per frame
    void Update()
    {
        currentSpeedY = 0;
        currentSpeedX = 0;

        point = target.transform.position;


    }
    
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, point, Time.deltaTime * speed);


          //  rb2d.velocity = new Vector2(Mathf.Lerp(0, currentSpeedX, 0.8f),
          //                              Mathf.Lerp(0, currentSpeedY, 0.8f));

    }

    void OnMouseDown()
    {
 
    }

}


