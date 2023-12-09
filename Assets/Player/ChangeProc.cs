using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class ChangeProc : MonoBehaviour
{

    [SerializeField] private Volume globalVolume;
    private Vignette vignette;
    private Bloom bloom;

    private void Start()
    {

        globalVolume.profile.TryGet<Vignette>(out vignette);
        globalVolume.profile.TryGet<Bloom>(out bloom);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            vignette.intensity.value = 0.6f;
            bloom.intensity.value = 2f;
            bloom.threshold.value = 0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            vignette.intensity.value = 0.2f;
            bloom.intensity.value = 1f;
            bloom.threshold.value = 1f;
        }
    }

    

}
