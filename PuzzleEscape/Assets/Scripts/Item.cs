using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int needIdItem = -1;

    [SerializeField] int id = -1;
    Sprite m_sprite = null;
    Color m_color;

    [SerializeField] bool canTake = true;

    private void Start()
    {
        m_sprite = GetComponent<SpriteRenderer>().sprite;
        m_color = GetComponent<SpriteRenderer>().color;
    }

    public void ChangeTake(bool flag)
    {
        canTake = flag;
    }

    private void OnMouseDown()
    {
        if (canTake)
        {
            if (needIdItem == -1)
            {
                AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, Camera.main.transform.position, GetComponent<AudioSource>().volume);

                AddItem();
            }
            else
            {
                if (FindObjectOfType<ItemsManager>().GetCurrentItem() != null)
                {
                    if (FindObjectOfType<ItemsManager>().GetCurrentItem().GetId() == needIdItem)
                    {
                        AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, Camera.main.transform.position, GetComponent<AudioSource>().volume);
                        FindObjectOfType<ItemsManager>().RemoveSelectItem();
                        AddItem();
                    }
                }
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
