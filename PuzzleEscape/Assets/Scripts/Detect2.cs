using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>().GetCurrentItem() != null)
        {
            if(FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 5)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}
