using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class PauseWindow : MonoBehaviour
{
    private static PauseWindow instance;
    private void Awake()
    {
        transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(-1298, -3);
        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(1130, 712.754f);
        instance = this;
        transform.Find("resumeBtn").GetComponent<Button_UI>().ClickFunc = () => GameHandler.ResumeGame();
        transform.Find("mainMenuBtn").GetComponent<Button_UI>().ClickFunc = () => Loader.Load(Loader.Scene.MainMenu);

        Hide();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic()
    {
        instance.Show();
    }

    public static void HideStatic()
    {
        instance.Hide();
    }
}
