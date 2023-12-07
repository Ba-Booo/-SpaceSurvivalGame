using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{   

    Slider SliderData;

    void Start()
    {
        SliderData = GetComponent<Slider>();
        SliderData.value = SceneVariable.VolumeData;
    }

    void Update()
    {
        SceneVariable.VolumeData = SliderData.value;
    }

}
