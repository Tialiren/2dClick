using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    private bool scalingUp = true;
    public float scaleSpeed;
    public float scaleRate;
    private float scaleTimer;

    public Vector3 startScale;
    public Vector3 endScale;

    // Update is called once per frame
    void Update()
    {
        scaleTimer += Time.deltaTime;

        if (scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, endScale, scaleSpeed * Time.deltaTime);
        }
        /*else if (!scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, startScale, scaleSpeed * Time.deltaTime);
        }

        if (scaleTimer >= scaleRate)
        {
            if (scalingUp) { scalingUp = false; }
            else if (!scalingUp) { scalingUp = true; }
            scaleTimer = 0;
        }*/
    }
}
