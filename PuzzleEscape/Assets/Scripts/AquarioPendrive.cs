using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquarioPendrive : MonoBehaviour
{

    [SerializeField] GameObject item = null;
    [SerializeField] Sprite aquarioQuebrado = null;

    bool isBreak = false;

    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>().GetCurrentItem())
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 6 && !isBreak)
            {
                item.SetActive(true);
                FindObjectOfType<ItemsManager>().RemoveSelectItem();
                GetComponent<AudioSource>().Play();
                GetComponent<SpriteRenderer>().sprite = aquarioQuebrado;
                isBreak = true;
            }
        }
    }
}
