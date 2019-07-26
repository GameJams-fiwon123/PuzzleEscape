using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] int id = 0;
    bool isEnabled = false;

    private void OnMouseDown()
    {
        isEnabled = !isEnabled;
        transform.GetChild(0).gameObject.SetActive(!transform.GetChild(0).gameObject.activeSelf);
        FindObjectOfType<TilesManager>().SetEnableTile(id, isEnabled);
        GetComponent<AudioSource>().Play();
    }


}
