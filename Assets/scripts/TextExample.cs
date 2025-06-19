using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextExample : MonoBehaviour
{
    [SerializeField] Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Hello, Unity!";
    }
}
