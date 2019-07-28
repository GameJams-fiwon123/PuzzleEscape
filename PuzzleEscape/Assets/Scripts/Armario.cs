using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armario : MonoBehaviour
{
    [SerializeField] GameObject armarioOpen = null;

    int needIdItem = 2;
    bool isOpen = false;

    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>().GetCurrentItem() != null)
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == needIdItem && !isOpen)
            {
                FindObjectOfType<ItemsManager>().RemoveSelectItem();
                gameObject.SetActive(false);
                isOpen = true;
                armarioOpen.SetActive(true);
            }
        }
    }
}
