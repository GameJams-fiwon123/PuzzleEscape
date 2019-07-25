using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chinelo : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<Animator>().Play("OpenChinelo");
    }
}
