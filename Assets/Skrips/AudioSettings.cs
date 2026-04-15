using UnityEngine;
using TMPro;

public class AudioSettings : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    private bool isMuted = false;

    void Start()
    {
        UpdateText();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;

        AudioListener.volume = isMuted ? 0f : 1f;

        UpdateText();
    }

    void UpdateText()
    {
        if (buttonText != null)
        {
            buttonText.text = isMuted ? "Mute: OFF" : "Mute: ON";
        }
    }
}