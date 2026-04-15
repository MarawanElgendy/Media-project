using UnityEngine;

public class ToggleObjectives : MonoBehaviour
{
    public GameObject objectivesPanel;

    public void TogglePanel()
    {
        objectivesPanel.SetActive(!objectivesPanel.activeSelf);
    }
}