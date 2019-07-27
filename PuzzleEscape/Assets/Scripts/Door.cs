using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Sprite spriteOpenDoor = null;
    [SerializeField] SpriteRenderer backgroundRoom = null;

    [SerializeField] AudioClip audioDestrancar = null;
    bool isLocked = true;

    private void OnMouseDown()
    {
        if (isLocked)
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem() != null)
            {
                if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 3)
                {
                    isLocked = false;
                    GetComponent<AudioSource>().clip = audioDestrancar;
                    GetComponent<AudioSource>().Play();
                    backgroundRoom.sprite = spriteOpenDoor;
                }
                else
                    GetComponent<AudioSource>().Play();
            }
            else
            {
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            FindObjectOfType<GameManager>().WinGame();
        }
    }
}
