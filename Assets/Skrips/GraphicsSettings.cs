using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class GraphicsSettings : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    void Start()
    {
        dropdown.ClearOptions();

        List<string> options = new List<string>();

        foreach (string quality in QualitySettings.names)
        {
            options.Add(quality);
        }

        dropdown.AddOptions(options);

        dropdown.value = QualitySettings.GetQualityLevel();
        dropdown.RefreshShownValue();
    }

    public void SetQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
