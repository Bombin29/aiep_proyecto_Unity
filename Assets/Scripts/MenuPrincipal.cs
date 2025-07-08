using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class MenuPrincipal : MonoBehaviour
{
    // Esta función será llamada por el botón
    public void Jugar()
    {
        // Carga la escena del juego, que está en la posición 0 en Build Settings
        SceneManager.LoadScene(0);
    }
}
