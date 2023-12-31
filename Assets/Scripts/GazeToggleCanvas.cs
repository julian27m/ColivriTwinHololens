using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeToggleCanvas : MonoBehaviour
{
    public GameObject canvasToToggle;

    private void Start()
    {
        // Ensure the canvas is initially hidden
        if (canvasToToggle != null)
        {
            canvasToToggle.SetActive(false);
        }
    }

    public void ShowCanvas()
    {
        if (canvasToToggle != null)
        {
            canvasToToggle.SetActive(true);
        }
    }

    public void HideCanvas()
    {
        if (canvasToToggle != null)
        {
            canvasToToggle.SetActive(false);
        }
    }
}
