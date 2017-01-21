using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public float Frequencia;

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    private bool done;
    private AudioClip audioClip1;
    private AudioClip audioClip2;
    private float[] data;


    private void Start()
    {
        data = new float[1024];
        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = GameObject.Find("AudioAux").GetComponent<AudioSource>();
        audioClip1 = Microphone.Start("", false, 1, 48000);
        StartCoroutine(Record());
    }

    void Update()
    {
        if(done)
        {
            StartCoroutine(Record());
        }
        if(audioSource1.isPlaying && !audioSource2.isPlaying)
        {
            Frequencia = GetFundamentalFrequency(audioSource1);
        }
        if (audioSource2.isPlaying && !audioSource1.isPlaying)
        {
            Frequencia = GetFundamentalFrequency(audioSource2);
        }
    }
    IEnumerator Record()
    {
        done = false;
        yield return new WaitForSecondsRealtime(1f);
        audioSource1.clip = audioClip1;
        audioSource2.Stop();
        audioSource1.Play();
        audioClip2 = Microphone.Start("", false, 1, 48000);
        yield return new WaitForSecondsRealtime(1f);
        audioSource2.clip = audioClip2;
        audioSource1.Stop();
        audioSource2.Play();
        //System.
        audioClip1 = Microphone.Start("", false, 1, 48000);
        audioSource1.clip = audioClip1;
        done = true;
        Debug.Log("done");
        yield break;
    }

    float GetFundamentalFrequency(AudioSource audioSource)
    {
        float fundamentalFrequency = 0.0f;
        audioSource.GetSpectrumData(data, 0, FFTWindow.BlackmanHarris);
        float s = 0.0f;
        int i = 0;
        for (int j = 1; j < 1024; j++)
        {
            if (s < data[j])
            {
                s = data[j];
                i = j;
            }
        }
        fundamentalFrequency = i * 44100 / 1024;
        return fundamentalFrequency;
    }
}
