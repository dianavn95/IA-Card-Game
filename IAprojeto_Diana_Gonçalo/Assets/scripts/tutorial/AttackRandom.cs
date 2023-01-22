using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttackRandom : MonoBehaviour
{
    //variáveis do IDs das cartas do player
    private bool ID1;
    private bool ID2;
    private bool ID3;
    private bool ID4;
    private bool ID5;
    private bool ID6;


    //variáveis do IDs das cartas do bot
    private bool ID7;
    private bool ID8;
    private bool ID9;
    private bool ID10;
    private bool ID11;
    private bool ID12;

    //bot
    private int ValorIDB;
    
    //player
    private int ValorIDP;

    public void EscolherAtacar()
    {
        ValorIDB = Random.Range(7,12);
        ValorIDP = Random.Range(1, 6);

        if (ValorIDB == 7)
        {
            ID7 = true;
        }

        if (ValorIDB == 8)
        {
            ID8 = true;
        }

        if (ValorIDB == 9)
        {
            ID9 = true;
        }

        if (ValorIDB == 10)
        {
            ID10 = true;
        }

        if (ValorIDB == 11)
        {
            ID11 = true;
        }

        if (ValorIDB == 12)
        {
            ID12 = true;
        }
    } 
}
