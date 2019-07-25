using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedDown : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<FrameManager>().ShowBedDown();
    }
}
