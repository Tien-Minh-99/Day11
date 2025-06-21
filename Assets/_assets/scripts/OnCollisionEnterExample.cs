using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnterExample : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hinh tru da cham vao hinh vuong");
    }

}
