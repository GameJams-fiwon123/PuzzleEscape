using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peixe : MonoBehaviour
{

    private void OnMouseDown()
    {
        FindObjectOfType<FrameManager>().ShowAquario();
    }
}
