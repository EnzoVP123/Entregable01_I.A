using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuConroller : MonoBehaviour
{
    public void CambiarEscenario(string escenario)
    {
        SceneManager.LoadScene(escenario);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
