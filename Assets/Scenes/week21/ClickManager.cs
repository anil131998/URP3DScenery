using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    [SerializeField] SaveDataSO saveData;
    int curCount;
    int totCount;
    [SerializeField] TMP_Text clickCount;
    [SerializeField] TMP_Text totlclickCount;


    private void Start()
    {
        curCount = 0;
        totCount = saveData.ClickCount;

        clickCount.text = "Click Count - " + curCount;
        totlclickCount.text = "Total Count - " + totCount;
    }

    private void OnEnable()
    {
        Eventmanager.buttonClick += increaseCount;
    }
    
    private void increaseCount()
    {
        curCount++;
        totCount++;
        clickCount.text = "Click Count - " + curCount;
        totlclickCount.text = "Total Count - " + totCount;
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse0))
    //    {
    //        curCount++;
    //        totCount++;
    //        clickCount.text = "Click Count - " + curCount;
    //        totlclickCount.text = "Total Count - " + totCount;
    //    }
    //}

    private void OnDisable()
    {
        Eventmanager.buttonClick -= increaseCount;
        saveData.ClickCount = totCount;
    }

}
