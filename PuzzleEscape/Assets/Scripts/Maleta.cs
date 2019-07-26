using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maleta : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<FrameManager>().ShowMaleta();
    }
}
