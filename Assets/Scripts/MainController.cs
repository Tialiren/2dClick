using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _textField.text = _count.ToString();
    }

    public static int _count;
    
    public static int Count { get => _count; set => _count = value; }


    public UnityEngine.UI.Text _textField;
    public UnityEngine.UI.Text TextField { get => _textField; set => _textField = value; }

    

    public static void CalcClick()
    {
        Count++;
    }

    public void CalcClick2()
    {
        Count++;
    }

}
