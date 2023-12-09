using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text fps_txt;
    [SerializeField] private float updateInterval = 0.5f;  // Update interval in seconds
    private float accum = 0;             // FPS accumulated over the interval
    private int frames = 0;              // Frames drawn over the interval
    private float timeleft;              // Left time for current interval

    void Start()
    {
        timeleft = updateInterval;
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        frames++;

        // Interval ended - update GUI text and start new interval
        if (timeleft <= 0.0)
        {
            // display two fractional digits (f2 format)
            float fps = accum / frames;
            string format = System.String.Format("{0:F2} FPS", fps);

            fps_txt.text = format;

            timeleft = updateInterval;
            accum = 0.0F;
            frames = 0;
        }
    }
}
