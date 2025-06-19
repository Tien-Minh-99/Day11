using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEXample : MonoBehaviour
{
    public class TextExample : MonoBehaviour
    {
        public Text myText;
        void Start()
        {
            myText.text = "Hello, Unity!";
        }
    }
}
