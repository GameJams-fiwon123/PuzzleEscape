using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chinelo : MonoBehaviour
{
    [SerializeField] GameObject code5 = null;
    bool isOpen = false;

    private void OnMouseDown()
    {
        if (!isOpen)
        {
            GetComponent<Animator>().Play("OpenChinelo");
            code5.SetActive(true);
            isOpen = true;
            GetComponent<AudioSource>().Play();
        }
    }
}
