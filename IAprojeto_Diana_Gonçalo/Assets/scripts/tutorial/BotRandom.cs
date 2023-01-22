using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BotRandom : MonoBehaviour
{
    //variáveis dos GameObject das cartas do inimigo
    public GameObject UseTsunami;
    public GameObject UseTerramoto;
    public GameObject UseFogo;
    public GameObject UseTrevoada;
    public GameObject UseTornado;
    public GameObject UseVolcao;


    //variáveis das cartas do player

    //carta tsunami têm ID = 1;
    public TMP_Text VidaTexto1;
    private float vida1;
    private float defesa1;
    private float ataque1;


    //carta terramoto têm ID = 2;
    public TMP_Text VidaTexto2;
    private float vida2;
    private float defesa2;
    private float ataque2;


    //carta fogo têm ID = 3;
    public TMP_Text VidaTexto3;
    private float vida3;
    private float defesa3;
    private float ataque3;


    //carta trovoadas têm ID = 4;
    public TMP_Text VidaTexto4;
    private float vida4;
    private float defesa4;
    private float ataque4;


    //carta tornado têm ID = 5;
    public TMP_Text VidaTexto5;
    private float vida5;
    private float defesa5;
    private float ataque5;


    //carta volcão têm ID = 6;
    public TMP_Text VidaTexto6;
    private float vida6;
    private float defesa6;
    private float ataque6;



    //<--------------------------------------------------------------------------->

    //variáveis das cartas do inimigo

    //carta tsunami têm ID = 7;
    public TMP_Text VidaTexto7;
    private float vida7;
    private float defesa7;
    private float ataque7;


    //carta terramoto têm ID = 8;
    public TMP_Text VidaTexto8;
    private float vida8;
    private float defesa8;
    private float ataque8;


    //carta fogo têm ID = 9;
    public TMP_Text VidaTexto9;
    private float vida9;
    private float defesa9;
    private float ataque9;


    //carta trovoadas têm ID = 10;
    public TMP_Text VidaTexto10;
    private float vida10;
    private float defesa10;
    private float ataque10;


    //carta tornado têm ID = 11;
    public TMP_Text VidaTexto11;
    private float vida11;
    private float defesa11;
    private float ataque11;


    //carta volcão têm ID = 12;
    public TMP_Text VidaTexto12;
    private float vida12;
    private float defesa12;
    private float ataque12;


    //<--------------------------------------------------------------------------->

    //ao iniciar o jogo estes são os valores das stats
    //isto vai servir para depois podermos calcular os valores dos ataques de cada um dos lados (player e bot)

    private void Start()
    {
        //carta tsunami do player com ID = 1;
        vida1 = 28;
        defesa1 = 14;
        ataque1 = 10;

        //carta terramoto do player com ID = 2;
        vida2 = 24;
        defesa2 = 15;
        ataque2 = 9;

        //carta fogo do player com ID = 3;
        vida3 = 27;
        defesa3 = 13;
        ataque3 = 10;

        //carta trovoadas do player com ID = 4;
        vida4 = 24;
        defesa4 = 16;
        ataque4 = 5;

        //carta tornado do player com ID = 5;
        vida5 = 26;
        defesa5 = 15;
        ataque5 = 9;

        //carta volcão do player com ID = 6;
        vida6 = 27;
        defesa6 = 13;
        ataque6 = 10;


        //<--------------------------------------------------------------------------->

        //carta tsunami do bot com ID = 7;
        vida7 = 28;
        defesa7 = 14;
        ataque7 = 10;

        //carta terramoto do bot com ID = 8;
        vida8 = 24;
        defesa8 = 15;
        ataque8 = 9;

        //carta fogo do bot com ID = 9;
        vida9 = 27;
        defesa9 = 13;
        ataque9 = 10;

        //carta trovoadas do bot com ID = 10;
        vida10 = 24;
        defesa10 = 16;
        ataque10 = 5;

        //carta tornado do bot com ID = 11;
        vida11 = 26;
        defesa11 = 15;
        ataque11 = 9;

        //carta volcão do bot com ID = 12;
        vida12 = 27;
        defesa12 = 13;
        ataque12 = 10;
    }


    //<--------------------------------------------------------------------------->

    //jogador ataca o bot com as seguintes funções
    //agora usamos funções únicas para quando se clica numa das cartas (depois de clicar no use)


    /*a lógica destas funções é: o jogador clica numa carta e ao clicar no "use" dentro da info card
     torna "visível" os botões das cardas inimigas.
    
    Logo de seguida o jogador escolhe uma das cartas inimigas, e ao clicar nela a função é ativada.
    
     Dentro de cada função vai ser chamado um enumerator para que o bot aguarde 4 segundos antes de atacar.
    
     Dentro do enumerator vai ser chamada uma função para o bot escolher uma carta sua e outra do player aleatóriamente.*/



    //Se o player escolher usar a sua carta do tsunami a função é ativada
    public void PlayerTsunamiUse()
    {
        UseTsunami.SetActive(true);
    }

    //Se o player escolher usar a sua carta do terramoto a função é ativada
    public void PlayerTerramotoUse()
    {
        UseTerramoto.SetActive(true);
    }

    //Se o player escolher usar a sua carta do fogo a função é ativada
    public void PlayerFogoUse()
    {
        UseFogo.SetActive(true);
    }

    //Se o player escolher usar a sua carta do trevoadas a função é ativada
    public void PlayerTrevoadasUse()
    {
        UseTrevoada.SetActive(true);
    }

    //Se o player escolher usar a sua carta do tornado a função é ativada
    public void PlayerTornadoUse()
    {
        UseTornado.SetActive(true);
    }

    //Se o player escolher usar a sua carta do volcão a função é ativada
    public void PlayerVolcaoUse()
    {
        UseVolcao.SetActive(true);
    }



    //<-------------------------------TSUNAMI PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami1()
    {
        vida7 = (ataque1 * ataque1) / (ataque1 + defesa7);
        VidaTexto7.text = vida7.ToString();
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto1()
    {
        VidaTexto8.text = vida8.ToString();
        vida8 = (ataque1 * ataque1) / (ataque1 + defesa8);
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo1()
    {
        VidaTexto9.text = vida9.ToString();
        vida9 = (ataque1 * ataque1) / (ataque1 + defesa9);
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada1()
    {
        VidaTexto10.text = vida10.ToString();
        vida10 = (ataque1 * ataque1) / (ataque1 + defesa10);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado1()
    {
        VidaTexto11.text = vida11.ToString();
        vida11 = (ataque1 * ataque1) / (ataque1 + defesa11);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao1()
    {
        VidaTexto12.text = vida12.ToString();
        vida12 = (ataque1 * ataque1) / (ataque1 + defesa12);
    }



    //<-------------------------------TERRAMOTO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami2()
    {
        VidaTexto7.text = vida7.ToString();
        vida7 = (ataque2 * ataque2) / (ataque2 + defesa7);
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto2()
    {
        VidaTexto8.text = vida8.ToString();
        vida8 = (ataque2 * ataque2) / (ataque2 + defesa8);
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo2()
    {
        VidaTexto9.text = vida9.ToString();
        vida9 = (ataque2 * ataque2) / (ataque2 + defesa9);
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada2()
    {
        VidaTexto10.text = vida10.ToString();
        vida10 = (ataque2 * ataque2) / (ataque2 + defesa10);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado2()
    {
        VidaTexto11.text = vida11.ToString();
        vida11 = (ataque2 * ataque2) / (ataque2 + defesa11);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao2()
    {
        VidaTexto12.text = vida12.ToString();
        vida12 = (ataque2 * ataque2) / (ataque2 + defesa12);
    }


    //<-------------------------------FOGO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami3()
    {
        VidaTexto7.text = vida7.ToString();
        vida7 = (ataque3 * ataque3) / (ataque3 + defesa7);
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto3()
    {
        VidaTexto8.text = vida8.ToString();
        vida8 = (ataque3 * ataque3) / (ataque3 + defesa8);
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo3()
    {
        VidaTexto9.text = vida9.ToString();
        vida9 = (ataque3 * ataque3) / (ataque3 + defesa9);
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada3()
    {
        VidaTexto10.text = vida10.ToString();
        vida10 = (ataque3 * ataque3) / (ataque3 + defesa10);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado3()
    {
        VidaTexto11.text = vida11.ToString();
        vida11 = (ataque3 * ataque3) / (ataque3 + defesa11);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao3()
    {
        VidaTexto12.text = vida12.ToString();
        vida12 = (ataque3 * ataque3) / (ataque3 + defesa12);
    }



    //<-------------------------------TROVOADA PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami4()
    {
        VidaTexto7.text = vida7.ToString();
        vida7 = (ataque4 * ataque4) / (ataque4 + defesa7);
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto4()
    {
        VidaTexto8.text = vida8.ToString();
        vida8 = (ataque4 * ataque4) / (ataque4 + defesa8);
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo4()
    {
        VidaTexto9.text = vida9.ToString();
        vida9 = (ataque4 * ataque4) / (ataque4 + defesa9);
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada4()
    {
        VidaTexto10.text = vida10.ToString();
        vida10 = (ataque4 * ataque4) / (ataque4 + defesa10);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado4()
    {
        VidaTexto11.text = vida11.ToString();
        vida11 = (ataque4 * ataque4) / (ataque4 + defesa11);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao4()
    {
        VidaTexto12.text = vida12.ToString();
        vida12 = (ataque4 * ataque4) / (ataque4 + defesa12);
    }


    //<-------------------------------TORNADO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami5()
    {
        VidaTexto7.text = vida7.ToString();
        vida7 = (ataque5 * ataque5) / (ataque5 + defesa7);
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto5()
    {
        VidaTexto8.text = vida8.ToString();
        vida8 = (ataque5 * ataque5) / (ataque5 + defesa8);
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo5()
    {
        VidaTexto9.text = vida9.ToString();
        vida9 = (ataque5 * ataque5) / (ataque5 + defesa9);
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada5()
    {
        VidaTexto10.text = vida10.ToString();
        vida10 = (ataque5 * ataque5) / (ataque5 + defesa10);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado5()
    {
        VidaTexto11.text = vida11.ToString();
        vida11 = (ataque5 * ataque5) / (ataque5 + defesa11);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao5()
    {
        VidaTexto12.text = vida12.ToString();
        vida12 = (ataque5 * ataque5) / (ataque5 + defesa12);
    }


    //<-------------------------------VOLCÃO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami6()
    {
        VidaTexto7.text = vida7.ToString();
        vida7 = (ataque6 * ataque6) / (ataque6 + defesa7);
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto6()
    {
        VidaTexto8.text = vida8.ToString();
        vida8 = (ataque6 * ataque6) / (ataque6 + defesa8);
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo6()
    {
        VidaTexto9.text = vida9.ToString();
        vida9 = (ataque6 * ataque6) / (ataque6 + defesa9);
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada6()
    {
        VidaTexto10.text = vida10.ToString();
        vida10 = (ataque6 * ataque6) / (ataque6 + defesa10);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado6()
    {
        VidaTexto11.text = vida11.ToString();
        vida11 = (ataque6 * ataque6) / (ataque6 + defesa11);
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao6()
    {
        VidaTexto12.text = vida12.ToString();
        vida12 = (ataque6 * ataque6) / (ataque6 + defesa12);
    }
}
