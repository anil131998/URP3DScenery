using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecondCounter : MonoBehaviour
{

    int count = 1000;
    [SerializeField] private TMP_Text text;

    private void Start()
    {
        count = 1000;
        text.text = count + "";
    }

    private void incrementCounter()
    {
        count++;
        text.text = count + "";
    }

    private void OnEnable()
    {
        Eventmanager.buttonClick += incrementCounter;
    }
    private void OnDisable()
    {
        Eventmanager.buttonClick -= incrementCounter;
    }

}
