using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botoesGerais : MonoBehaviour
{

    //função para iniciar o jogo
    public void Jogar()
    {
        SceneManager.LoadScene(2);
    }


    //função para ir para o menu da ajuda
    public void Ajuda()
    {
        SceneManager.LoadScene(1);
    }


    //função para abrir o menu principal
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


    //função para fechar a aplicação
    public void Fechar()
    {
        Application.Quit();
    }
}
