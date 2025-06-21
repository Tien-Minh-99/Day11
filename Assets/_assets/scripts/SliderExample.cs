using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour
{
    public Slider mySlider;
    public void OnSliderValueChange(float value) // đây là biến tự đặt tên 
    {
        Debug.Log("slider value: " + value);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
