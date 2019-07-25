using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escrivaninha : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<FrameManager>().ShowPaper();
    }
}
