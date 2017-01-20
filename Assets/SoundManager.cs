using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public float testeFloat;

    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            StartCoroutine(Record());            
        }            
    }
    IEnumerator Record()
    {
        AudioClip lastRecorded;
        lastRecorded = Microphone.Start("", false, 1, 44100);
        AudioSource a = GetComponent<AudioSource>();
        a.clip = lastRecorded;
        yield return new WaitForSecondsRealtime(1f);
        testeFloat = GetFundamentalFrequency(a);
    }

    float GetFundamentalFrequency(AudioSource a)
    {
        float fundamentalFrequency = 0.0f;
        float[] data = new float[8192];
        a.GetSpectrumData(data, 0, FFTWindow.BlackmanHarris);
        float s = 0.0f;
        int i = 0;
        for (int j = 1; j < 8192; j++)
        {
            if (s < data[j])
            {
                s = data[j];
                i = j;
            }
        }
        fundamentalFrequency = i * 44100 / 8192;
        return fundamentalFrequency;
    }
}
