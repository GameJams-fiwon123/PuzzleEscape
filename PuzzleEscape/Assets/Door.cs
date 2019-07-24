using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Sprite spriteOpenDoor;

    [SerializeField] AudioClip audioDestrancar;
    bool isLocked = true;

    private void OnMouseDown()
    {
        if (isLocked)
            GetComponent<AudioSource>().Play();
        else
        {
            GetComponent<AudioSource>().clip = audioDestrancar;
            GetComponent<AudioSource>().Play();
            GetComponent<SpriteRenderer>().sprite = spriteOpenDoor;
        }
    }
}
