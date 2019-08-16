using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    [SerializeField]
    protected int _score;

    [SerializeField]
    protected int _lifeTime = 2;

    private bool scalingUp = true;
    public float scaleSpeed;


    public Vector3 startScale;
    public Vector3 endScale;

    public int Score { get => _score; set => _score = value; }

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

        if (scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, endScale, scaleSpeed * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        ScoreController.Main.SetScore(Score);
        Destroy(gameObject);
    }

}
