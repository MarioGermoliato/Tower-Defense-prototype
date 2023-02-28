using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SurvivalTime : MonoBehaviour
{
    [SerializeField] TMP_Text timerTxt;
    float timer;
    int timerChange;

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        timer += Time.deltaTime;
        timerChange = Mathf.RoundToInt(timer);
        timerTxt.text = timerChange.ToString();
    }
}
