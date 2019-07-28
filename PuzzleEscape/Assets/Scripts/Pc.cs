using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pc : MonoBehaviour
{
    bool isImpress = false;

    private void OnMouseDown()
    {
        if(FindObjectOfType<ItemsManager>().GetCurrentItem()){
            if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 7 && !isImpress)
            {
                GetComponent<AudioSource>().Play();
                FindObjectOfType<ItemsManager>().RemoveSelectItem();
                transform.GetChild(0).gameObject.SetActive(true);
                isImpress = true;
            }
        }
    }
}
