using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class janela : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
    }
}
