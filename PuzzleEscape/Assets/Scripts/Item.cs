using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int id = -1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ItemsManager>().AddItem(id, gameObject.GetComponent<SpriteRenderer>());
        Destroy(gameObject);
    }
}
