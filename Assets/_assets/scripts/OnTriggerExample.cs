using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExample : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hình tron di xuyen qua hinh vuong");
    }
}
