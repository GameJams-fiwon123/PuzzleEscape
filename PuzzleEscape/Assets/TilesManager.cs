using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour
{
    int index = 0;
    bool isFinish = false;

    public void SetEnableTile(int id, bool enable)
    {
        if (!isFinish)
        {
            if (enable) {
                switch (id)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        index++;
                        break;
                    default:
                        index--;
                        break;
                }
            }
            else
            {
                switch (id)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        index--;
                        break;
                    default:
                        index++;
                        break;
                }
            }

            if (index == 4)
            {
                GetComponent<Animator>().Play("OpenQuadro");
                isFinish = true;
            }

        }
    }
}
