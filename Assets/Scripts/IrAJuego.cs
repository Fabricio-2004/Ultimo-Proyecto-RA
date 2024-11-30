using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrAJuego : MonoBehaviour
{
    public void IrALaPantallaDeJuego()
    {
        SceneManager.LoadScene("Juego");
    }
}
