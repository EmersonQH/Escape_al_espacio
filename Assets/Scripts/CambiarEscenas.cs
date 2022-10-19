using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenas : MonoBehaviour
{
    public void MenuPrincipal(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
    }
    public void EmpezarJuego(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void Historia(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }
    public void CerrarJuego(){
        Application.Quit();
        Debug.Log("Salir");
    }
}
