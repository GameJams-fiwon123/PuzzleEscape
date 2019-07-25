﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] int id = 0;
    bool isEnabled = false;

    private void OnMouseDown()
    {
        isEnabled = !isEnabled;
        FindObjectOfType<TilesManager>().SetEnableTile(id, isEnabled);
    }


}
