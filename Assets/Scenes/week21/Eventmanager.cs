using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventmanager : MonoBehaviour
{

    public static UnityAction buttonClick;

    public void ButtonClicked()
    {
        buttonClick?.Invoke();
    }

}
