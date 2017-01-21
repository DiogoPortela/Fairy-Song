using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public float testeFloat;
    public bool done = true;
    float[] data;

    private AudioSource a;

    private void Start()
    {
        data = new float[128];
        a = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            StartCoroutine(Record());
        }
        testeFloat = GetFundamentalFrequency(a);
    }
    IEnumerator Record()
    {
        done = false;
        AudioClip lastRecorded = Microphone.Start("", false, 2, 44100);
        yield return new WaitForSecondsRealtime(2f);
        a.clip = lastRecorded;
        a.Play();
        testeFloat = GetFundamentalFrequency(a);


        done = true;
    }

    float GetFundamentalFrequency(AudioSource a)
    {
        float fundamentalFrequency = 0.0f;
        a.GetSpectrumData(data, 0, FFTWindow.BlackmanHarris);
        float s = 0.0f;
        int i = 0;
        for (int j = 1; j < 128; j++)
        {
            if (s < data[j])
            {
                s = data[j];
                i = j;
            }
        }
        fundamentalFrequency = i * 44100 / 128;
        return fundamentalFrequency;
    }
}
