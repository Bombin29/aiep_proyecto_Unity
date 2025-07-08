using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class MenuPrincipal : MonoBehaviour
{
    // Esta funci�n ser� llamada por el bot�n
    public void Jugar()
    {
        // Carga la escena del juego, que est� en la posici�n 0 en Build Settings
        SceneManager.LoadScene(0);
    }
}
