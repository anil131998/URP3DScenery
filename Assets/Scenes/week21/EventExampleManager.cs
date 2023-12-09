using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventExampleManager : MonoBehaviour
{

    public static UnityAction evnt;

    public void buttonClicked()
    {
        evnt?.Invoke();
    }

}
