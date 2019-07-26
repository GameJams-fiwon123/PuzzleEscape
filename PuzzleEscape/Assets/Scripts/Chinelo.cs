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
            isOpen = true;
            GetComponent<AudioSource>().Play();
        }
    }

    public void FinishAnimation()
    {
        code5.GetComponent<Item>().ChangeTake(true);
    }
}
