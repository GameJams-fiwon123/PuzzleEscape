using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int id = -1;
    Sprite m_sprite = null;
    Color m_color;

    private void Start()
    {
        m_sprite = GetComponent<SpriteRenderer>().sprite;
        m_color = GetComponent<SpriteRenderer>().color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        FindObjectOfType<ItemsManager>().AddItem(this);
        Destroy(gameObject);
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
