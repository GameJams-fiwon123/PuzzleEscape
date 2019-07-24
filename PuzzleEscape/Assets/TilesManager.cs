using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour
{

    [SerializeField] int[] sequencia;
    int index = 0;
    bool isFinish = false;

    public void ClickTile(int id)
    {
        if (!isFinish)
        {
            if (sequencia[index] == id)
            {
                index++;
                if (index == sequencia.Length)
                {
                    GetComponent<Animator>().Play("OpenQuadro");
                    isFinish = true;
                }
            }
            else
            {
                index = 0;
                print("Errado");
            }
        }
    }

    private void OnMouseDown()
    {
        index = 0;
        print("Errado");
    }
}
