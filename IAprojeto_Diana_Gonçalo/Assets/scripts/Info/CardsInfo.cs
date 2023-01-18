using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardsInfo : MonoBehaviour
{
    //vari�vel do titulo
    public TMP_Text titulo;

    //vari�veis da descri��o
    public TMP_Text descricao1;
    public TMP_Text descricao2;


    //fun��o ativa quando clicar na carta do tsunami
    public void TsunamiInfoCard()
    {
        titulo.text = "TSUNAMI";
        descricao1.text = "Drown your enemy and take is power. If you use this card, the enemy card attacked will lose 1 attack point.";
        descricao2.text = "When used, this card activates a cooldown that will last 5 rounds.";
    }

    //fun��o ativa quando clicar na carta do terramoto
    public void EarthquakeInfoCard()
    {
        titulo.text = "EARTHQUAKE";
        descricao1.text = "Break your enemy. If you use this card, all of the enemy cards will suffer 1 attack point.";
        descricao2.text = "When used, this card activates a cooldown that will last 4 rounds.";
    }

    //fun��o ativa quando clicar na carta do fogo
    public void FireInfoCard()
    {
        titulo.text = "FIRE";
        descricao1.text = "Burn them down. If you use this card, all of the enemy cards will suffer 2 attack point.";
        descricao2.text = "When used, this card activates a cooldown that will last 6 rounds.";
    }

    //fun��o ativa quando clicar na carta do rel�mpago
    public void LightningInfoCard()
    {
        titulo.text = "LIGHTNING";
        descricao1.text = "Strike them when they least expect. If you use this card, all of your cards will receive 1 life point.";
        descricao2.text = "When used, this card activates a cooldown that will last 3 rounds.";
    }

    //fun��o ativa quando clicar na carta do tornado
    public void TornadoInfoCard()
    {
        titulo.text = "TORNADO";
        descricao1.text = "Make them shiver. If you use this card, all of your enemy cards will lose 1 defence point.";
        descricao2.text = "When used, this card activates a cooldown that will last 7 rounds.";
    }


    //fun��o ativa quando clicar na carta do volc�o
    public void VolcanoInfoCard()
    {
        titulo.text = "VOLCANIC ERUPTION";
        descricao1.text = "No mercy. If you use this card, the enemy card attacked will receive a 2 round cooldown.";
        descricao2.text = "When used, this card activates a cooldown that will last 8 rounds.";
    }
}
