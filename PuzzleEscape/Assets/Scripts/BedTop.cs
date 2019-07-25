using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedTop : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<FrameManager>().ShowBedTop();
    }
}
