using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChessUIManager : MonoBehaviour
{
    [SerializeField] private GameObject UIPanel;
    [SerializeField] private TextMeshProUGUI resultText;

    public void HideUI()
    {
        UIPanel.SetActive(false);
    }

    public void OnGameFinished(string winnerName)
    {
        UIPanel.SetActive(true);
        resultText.text = $"{winnerName} Won!";
    }
    
}
