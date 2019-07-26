using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CodeNumber : MonoBehaviour
{
    int number = 0;

    public void UpNumber()
    {
        number++;
        if(number > 9)
        {
            number = 0;
        }
        GetComponent<TextMeshProUGUI>().text = number.ToString();
    }
}
