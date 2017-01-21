using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class teste : MonoBehaviour
{
    private int amountfreq = 120;
    private float[] freq = new float[1024];
    private float allfreqvalue;
    public AudioSource a;
    public int frequencia;

    private void Start()
    {
        a = GetComponent<AudioSource>();
    }
    private void Update()
    {
        frequencia = GetMaxFreq();
    }

    int GetMaxFreq()
    {
        for (int s = 0; s < amountfreq; s++)
            freq[s] = 0;

        allfreqvalue = 0;
        int x = 0;
        a.GetSpectrumData(freq, 0, FFTWindow.BlackmanHarris);
        for (int s = 0; s < amountfreq; s++)
            allfreqvalue = allfreqvalue + freq[s];
        return x;
    }
}
