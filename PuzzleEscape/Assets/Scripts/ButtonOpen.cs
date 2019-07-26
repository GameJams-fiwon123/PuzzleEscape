using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOpen : MonoBehaviour
{
    [SerializeField] Image maletaSprite = null;
    [SerializeField] Sprite maletaOpen = null;

    [SerializeField] TextMeshProUGUI number1 = null;
    [SerializeField] TextMeshProUGUI number2 = null;
    [SerializeField] TextMeshProUGUI number3 = null;
    [SerializeField] TextMeshProUGUI number4 = null;

    bool isOpen = false;

    public void OpenMaleta()
    {
        if (!isOpen) {
            if (number1.text == "1" &&
               number2.text == "9" &&
               number3.text == "6" &&
               number4.text == "4")
            {
                maletaSprite.sprite = maletaOpen;
                transform.GetChild(0).gameObject.SetActive(true);
                isOpen = true;
            }
        }
    }
}
