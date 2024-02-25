using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalidadController : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int calidad;
    void Star()
    {
        calidad = PlayerPrefs.GetInt("intCalidad", 4);
        dropdown.value = calidad;
        AjustarCalidad();
    }
    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("intCalidad", dropdown.value);
        calidad = dropdown.value;
    }
}

