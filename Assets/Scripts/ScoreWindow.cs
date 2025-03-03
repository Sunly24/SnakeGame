using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        // Find existing text component
        scoreText = GetComponentInChildren<TextMeshProUGUI>();

        // If not found, create one
        if (scoreText == null)
        {
            GameObject textObject = new GameObject("scoreText");
            textObject.transform.SetParent(transform);

            // Position it properly
            RectTransform rectTransform = textObject.AddComponent<RectTransform>();
            rectTransform.anchoredPosition = Vector2.zero;
            rectTransform.sizeDelta = new Vector2(200, 50);

            // Add the text component
            scoreText = textObject.AddComponent<TextMeshProUGUI>();
            scoreText.fontSize = 36;
            scoreText.alignment = TextAlignmentOptions.Center;
            scoreText.text = "0";
        }
    }
    private void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = GameHandler.GetScore().ToString();
        }
    }
}