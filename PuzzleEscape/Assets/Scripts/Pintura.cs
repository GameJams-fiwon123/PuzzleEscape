using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintura : MonoBehaviour
{
    [SerializeField] GameObject item = null;

    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 8)
            GetComponent<Animator>().Play("OpenPintura");
    }

    public void FinishAnimation()
    {
        if (item)
        {
            item.GetComponent<Item>().ChangeTake(true);
        }
    }
}
