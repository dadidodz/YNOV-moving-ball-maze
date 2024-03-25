using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countUp = true;

    [Header("Format Settings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timerFormats = new Dictionary<TimerFormats, string>();

    // Start is called before the first frame update
    void Start()
    {
        timerFormats.Add(TimerFormats.Whole, "0");
        timerFormats.Add(TimerFormats.TenthDecimal, "0.0");
        timerFormats.Add(TimerFormats.HundrethsDecimal, "0.00");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countUp ? currentTime += Time.deltaTime : currentTime -= Time.deltaTime;
        timerText.text = hasFormat ? currentTime.ToString(timerFormats[format]) : currentTime.ToString();
    }
}

public enum TimerFormats{
    Whole,
    TenthDecimal,
    HundrethsDecimal
}
