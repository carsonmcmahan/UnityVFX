using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartButton(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void SettingsButton()
    {
        Debug.Log("Button Pressed");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
