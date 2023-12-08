using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChangeScript : MonoBehaviour
{

    AudioSource Sound;

    void Start()
    {
        Sound = GetComponent<AudioSource>();
        Sound.volume = SceneVariable.VolumeData;
    }
}
