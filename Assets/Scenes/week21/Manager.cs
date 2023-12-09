using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private Image imgUI;
    [SerializeField] private imageSO soimg;

    private void Start()
    {
        imgUI.sprite = soimg.img;
    }
}
