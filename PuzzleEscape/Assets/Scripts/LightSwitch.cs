using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] GameObject m_light = null;

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        m_light.SetActive(!m_light.activeSelf);
    }

}
