using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControladorDeSom : MonoBehaviour
{

    public AudioMixer meuMixer;

    public GameObject Btmute;
    public GameObject Btliga;

    // Start is called before the first frame update
    void Start()
    {
        float valorAudioInicial = PlayerPrefs.GetFloat("Volume");
        meuMixer.SetFloat("MasterVolume", valorAudioInicial);
        if(valorAudioInicial == 0)
        {
            Btmute.SetActive(true);
            Btliga.SetActive(false);
        }
        else
        {
            Btmute.SetActive(false);
            Btliga.SetActive(true);
        }
    }

    public void AlteraSom(float volAudio)
    {
        meuMixer.SetFloat("MasterVolume", volAudio);
        PlayerPrefs.SetFloat("Volume", volAudio);
    }
    
    
}
