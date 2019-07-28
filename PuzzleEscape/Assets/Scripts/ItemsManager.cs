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
            NextIem();

        }
        else if(Input.mouseScrollDelta.y < 0 || Input.GetKeyDown(KeyCode.Q))
        {
            PreviousItem();
        }
    }

    private void PreviousItem()
    {
        index--;

        if (index <= -1)
        {
            index = items.Count - 1;
        }

        SelectItem(index);
    }

    private void NextIem()
    {
        index++;

        if (index >= items.Count)
        {
            index = 0;
        }

        SelectItem(index);
    }

    public Item GetCurrentItem()
    {
        return currentItem;
    }

    public void SelectItem(int index)
    {
        if (items.Count > 0)
        {
            currentItem = items[index];
            slotItem.GetComponent<Image>().sprite = currentItem.GetSprite();
            slotItem.GetComponent<Image>().color = currentItem.GetColor();
        }
    }

    public void RemoveSelectItem()
    {
        items.RemoveAt(index);
        NextIem();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
        SelectItem(items.Count-1);
    }
}
