using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect5 : MonoBehaviour
{
    bool isPutted = false;

    private void OnMouseDown()
    {
        if (!isPutted)
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem() != null)
            {
                if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 4)
                {
                    FindObjectOfType<ItemsManager>().RemoveSelectItem();
                    transform.GetChild(0).gameObject.SetActive(true);
                    GetComponent<AudioSource>().Play();
                    isPutted = true;
                }
            }
        }
    }
}
