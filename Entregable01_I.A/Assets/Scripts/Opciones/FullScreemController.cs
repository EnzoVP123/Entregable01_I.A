using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class FullScreemController : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Dropdown resolucionDropDown;
    Resolution[] resolucion;

    void Start() 
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else{
            toggle.isOn = false;
        }
    }
    public void ActivarPantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void ValidarResolucion()
    {
        resolucion = Screen.resolutions;
        resolucionDropDown.ClearOptions();
        List<string> opciones = new List<string>();
        int resolucionActual = 0;
        for (int i = 0; i < resolucion.Length; i++)
        {
            string opcion = resolucion[i].width + " x " + resolucion[i].height;
            opciones.Add(opcion);
            if (Screen.fullScreen && resolucion[i].width == Screen.currentResolution.width && resolucion[i].width == Screen.currentResolution.height)
            {
                resolucionActual = i;
            }

        }
        resolucionDropDown.AddOptions(opciones);
        resolucionDropDown.value = resolucionActual;
        resolucionDropDown.RefreshShownValue();

        resolucionDropDown.value = PlayerPrefs.GetInt("IntResolucion", 0);
    }

    public void CambiarResolucion(int IntResolucion)
    {
        PlayerPrefs.SetInt("IntResolucion", resolucionDropDown.value);
        Resolution resolucions = resolucion[IntResolucion];
        Screen.SetResolution(resolucions.width, resolucions.height, Screen.fullScreen);
    }

}