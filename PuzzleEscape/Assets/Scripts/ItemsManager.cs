using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsManager : MonoBehaviour
{
    private List<Item> items = null;
    private int index = 0;
    private Item currentItem = null;

    Transform slotItem;

    // Start is called before the first frame update
    void Start()
    {
        items = new List<Item>();
        slotItem = transform.GetChild(0).GetChild(0);
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y > 0 || Input.GetKeyDown(KeyCode.E))
        {
            index++;

            if (index >= items.Count)
            {
                index = 0;
            }

            SelectItem(index);
            
        }
        else if(Input.mouseScrollDelta.y < 0 || Input.GetKeyDown(KeyCode.Q))
        {
            index--;

            if (index <= -1)
            {
                index = items.Count-1;
            }

            SelectItem(index);
        }
    }

    public void SelectItem(int index)
    {
        currentItem = items[index];
        slotItem.GetComponent<Image>().sprite = currentItem.GetSprite();
        slotItem.GetComponent<Image>().color = currentItem.GetColor();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }
}
