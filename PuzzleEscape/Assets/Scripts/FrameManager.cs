using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject cam, ceiling, floor, goBack, aquario, bed;

    private int posXFrame0 = 0;
    private int posXFrame1 = 18;
    private int posXFrame2 = 36;
    private int posXFrame3 = 54;

    public void MoveCamToFrame(int frame)
    {
        Vector3 newPos = cam.transform.position;

        switch (frame)
        {
            case 0:
                newPos.x = posXFrame0;
                break;
            case 1:
                newPos.x = posXFrame1;
                break;
            case 2:
                newPos.x = posXFrame2;
                break;
            case 3:
                newPos.x = posXFrame3;
                break;
        }

        cam.transform.position = newPos;
    }

    public void ShowCeiling()
    {
        ceiling.SetActive(true);
        goBack.SetActive(true);
    }

    public void ShowFloor()
    {
        floor.SetActive(true);
        goBack.SetActive(true);
    }

    public void ShowAquario()
    {
        aquario.SetActive(true);
        goBack.SetActive(true);
    }

    public void ShowBed()
    {
        bed.SetActive(true);
        goBack.SetActive(true);
    }

    public void Hide()
    {
        bed.SetActive(false);
        aquario.SetActive(false);
        floor.SetActive(false);
        ceiling.SetActive(false);
        goBack.SetActive(false);
    }
}
