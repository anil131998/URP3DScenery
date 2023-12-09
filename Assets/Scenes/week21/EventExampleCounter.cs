using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventExampleCounter : MonoBehaviour
{
    private int cntr = 0;
    [SerializeField] private TMP_Text cntrText;

    private void increment()
    {
        cntr++;
        cntrText.text = cntr + "";
    }

    private void OnEnable()
    {
        EventExampleManager.evnt += increment;
    }
    private void OnDisable()
    {
        EventExampleManager.evnt -= increment;
    }

}
