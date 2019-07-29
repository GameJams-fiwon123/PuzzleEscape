using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintura : MonoBehaviour
{
    [SerializeField] SpriteRenderer _sprite = null;
    [SerializeField] Sprite _spriteOpen = null;

    [SerializeField] GameObject item = null;

    private void OnMouseDown()
    {
        if (FindObjectOfType<ItemsManager>())
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem())
            {
                if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == 8)
                {
                    FindObjectOfType<ItemsManager>().RemoveSelectItem();
                    item.SetActive(true);
                    item.GetComponent<Item>().ChangeTake(true);
                    _sprite.sprite = _spriteOpen;
                }
            }
        }
    }

    public void FinishAnimation()
    {
        if (item)
        {
            item.GetComponent<Item>().ChangeTake(true);
        }
    }
}
