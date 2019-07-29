using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquarioPendrive : MonoBehaviour
{

    [SerializeField] GameObject item = null;
    [SerializeField] Sprite aquarioQuebrado = null;

    [SerializeField] SpriteRenderer quebradoBackground = null;

    bool isBreak = false;

    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>().GetCurrentItem())
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 6 && !isBreak)
            {
                FindObjectOfType<ItemsManager>().RemoveSelectItem();
                GetComponent<AudioSource>().Play();
                quebradoBackground.sprite = aquarioQuebrado;
                item.GetComponent<Item>().ChangeTake(true);
                item.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
                isBreak = true;
            }
        }
    }
}
