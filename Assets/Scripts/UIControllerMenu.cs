using UnityEngine;

public class UIControllerMenu : MonoBehaviour
{
    [SerializeField] private GameObject settingsPanel;

    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
}
