using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] int id = 0;

    private void OnMouseDown()
    {
        FindObjectOfType<TilesManager>().ClickTile(id);
    }


}
