using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquarioPendrive : MonoBehaviour
{

    [SerializeField] GameObject item;
    [SerializeField] Sprite aquarioQuebrado;

    bool isBreak = false;

    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 6 && !isBreak)
        {
            item.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = aquarioQuebrado;
            isBreak = true;
        }
    }
}
