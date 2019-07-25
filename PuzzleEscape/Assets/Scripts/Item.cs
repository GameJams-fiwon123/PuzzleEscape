using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int needIdItem = -1;

    [SerializeField] int id = -1;
    Sprite m_sprite = null;
    Color m_color;

    private void Start()
    {
        m_sprite = GetComponent<SpriteRenderer>().sprite;
        m_color = GetComponent<SpriteRenderer>().color;
    }

    private void OnMouseDown()
    {
        if (needIdItem == -1)
        {
            AddItem();
        }
        else
        {
            if (FindObjectOfType<ItemsManager>().GetCurrentItem() != null){
                if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == needIdItem)
                {
                    AddItem();
                    
                }
                else
                {
                    print("Precisa do item " + needIdItem.ToString());
                }
            }
            else
            {
                print("Precisa do item " + needIdItem.ToString());
            }
        }
    }

    private void AddItem()
    {
        FindObjectOfType<ItemsManager>().AddItem(this);
        gameObject.SetActive(false);
    }

    public Sprite GetSprite()
    {
        return m_sprite;
    }

    public Color GetColor()
    {
        return m_color;
    }

    public int GetId()
    {
        return id;
    }
}
