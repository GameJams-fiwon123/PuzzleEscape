using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect5 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>().GetCurrentItem() != null)
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 4)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}
