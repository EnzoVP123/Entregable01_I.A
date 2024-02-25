using UnityEngine;
using UnityEngine.UI;

public class VolumenController : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;

    void Start() 
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        ValidarVolumen();
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        ValidarVolumen();
    }

    public void ValidarVolumen()
    {
        if (sliderValue == 0)
        {
            imagenMute.enabled = true;
        }
        else{
            imagenMute.enabled = false;
        }
    }
}
