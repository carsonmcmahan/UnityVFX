using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    public ButtonManager buttonManager;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button buttonStart = root.Q<Button>("StartButton");
        Button buttonSettings = root.Q<Button>("SettingsButton");
        Button buttonQuit = root.Q<Button>("QuitButton");

        buttonStart.clicked += () => buttonManager.StartButton(1);
        buttonSettings.clicked += () => buttonManager.SettingsButton();
        buttonQuit.clicked += () => buttonManager.QuitButton();
    }
}
