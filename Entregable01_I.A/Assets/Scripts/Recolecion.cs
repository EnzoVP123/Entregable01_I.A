using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  TMPro;

public class Recolecion : MonoBehaviour
{
    public int cantidadGemas;
    public TextMeshProUGUI numero;
    private void Update()
    {
      numero.text = cantidadGemas.ToString();
    }
   private void OnTriggerEnter(Collider other) 
   {
       if (other.gameObject.CompareTag("Gemas")) 
       {
         Destroy(other.gameObject);
         cantidadGemas++;
       }
   }
}
