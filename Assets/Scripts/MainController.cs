using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public static MainController Main { get; private set; }

    private int _allScore;

    public UnityEngine.UI.Text _textField;
    public UnityEngine.UI.Text TextField { get => _textField; set => _textField = value; }

    private void Awake()
    {
        Main = this;
        _allScore = 0;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Reset()
    {
        _allScore = 0;
        TextField.text = _allScore.ToString();
    }

    public void SetScore(int score)
    {
        _allScore += score;
        TextField.text = _allScore.ToString();
    }

}
