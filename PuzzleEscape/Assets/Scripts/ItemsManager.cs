using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsManager : MonoBehaviour
{
    private Transform slots;

    // Start is called before the first frame update
    void Start()
    {
        slots = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectItem()
    {
        print("oi");
    }

    public void AddItem(int id, SpriteRenderer spriteRender)
    {
        int count = 0; 
        foreach( Transform slot in slots)
        {
            if (count == id)
            {
                slot.GetChild(0).GetComponent<Image>().sprite = spriteRender.sprite;
                slot.GetChild(0).GetComponent<Image>().color = spriteRender.color;
                print("Adicionado item " + id.ToString());
            }

            count++;
        }
    }
}
