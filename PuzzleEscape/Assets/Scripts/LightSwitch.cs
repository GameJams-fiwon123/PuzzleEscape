using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] GameObject m_light = null;
    [SerializeField] GameObject stars = null;

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        m_light.SetActive(!m_light.activeSelf);
        stars.SetActive(!stars.activeSelf);
    }

}
