using TMPro;
using UnityEngine;

public class FpsDisplay : MonoBehaviour
{
    public TextMeshProUGUI FPSDisplay;
    public bool showDecimalFPS = true;

    private float fps;

    void Update()
    {
        if (!FPSDisplay)
            return;

        fps = 1f / Time.deltaTime;

        ChangeTextColour();

        if (showDecimalFPS)
        {
            FPSDisplay.text = $"{fps:F1} FPS";
        }
        else
        {
            FPSDisplay.text = $"{fps:F0} FPS";
        }
    }

    void ChangeTextColour()
    {
        if (fps < 30)
        {
            FPSDisplay.color = Color.red;
        }
        else if (fps < 60)
        {
            FPSDisplay.color = Color.yellow;
        }
        else
        {
            FPSDisplay.color = Color.green;
        }
    }
}