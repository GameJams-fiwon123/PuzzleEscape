using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    [SerializeField] GameObject light;

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        light.SetActive(!light.activeSelf);
    }
}
