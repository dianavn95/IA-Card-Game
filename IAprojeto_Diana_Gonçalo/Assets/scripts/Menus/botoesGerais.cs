using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botoesGerais : MonoBehaviour
{

    //fun��o para iniciar o jogo
    public void Jogar()
    {
        SceneManager.LoadScene(2);
    }


    //fun��o para ir para o menu da ajuda
    public void Ajuda()
    {
        SceneManager.LoadScene(1);
    }


    //fun��o para abrir o menu principal
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


    //fun��o para fechar a aplica��o
    public void Fechar()
    {
        Application.Quit();
    }
}
