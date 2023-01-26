using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    private int cooldown1;


    //carta terramoto têm ID = 2;
    public TMP_Text VidaTexto2;
    private float vida2;
    private float defesa2;
    private float ataque2;
    private int cooldown2;


    //carta fogo têm ID = 3;
    public TMP_Text VidaTexto3;
    private float vida3;
    private float defesa3;
    private float ataque3;
    private int cooldown3;



    //carta trovoadas têm ID = 4;
    public TMP_Text VidaTexto4;
    private float vida4;
    private float defesa4;
    private float ataque4;
    private int cooldown4;


    //carta tornado têm ID = 5;
    public TMP_Text VidaTexto5;
    private float vida5;
    private float defesa5;
    private float ataque5;
    private int cooldown5;


    //carta volcão têm ID = 6;
    public TMP_Text VidaTexto6;
    private float vida6;
    private float defesa6;
    private float ataque6;
    private int cooldown6;



    //<--------------------------------------------------------------------------->

    //variáveis das cartas do inimigo

    //carta tsunami têm ID = 7;
    public GameObject carta7;
    public TMP_Text VidaTexto7;
    private float vida7;
    private float defesa7;
    public TMP_Text DefesaTexto7;
    private float ataque7;
    public TMP_Text AtaqueTexto7;
    private int cooldown7;


    //carta terramoto têm ID = 8;
    public GameObject carta8;
    public TMP_Text VidaTexto8;
    private float vida8;
    private float defesa8;
    public TMP_Text DefesaTexto8;
    private float ataque8;
    public TMP_Text AtaqueTexto8;
    private int cooldown8;


    //carta fogo têm ID = 9;
    public GameObject carta9;
    public TMP_Text VidaTexto9;
    private float vida9;
    private float defesa9;
    public TMP_Text DefesaTexto9;
    private float ataque9;
    public TMP_Text AtaqueTexto9;
    private int cooldown9;


    //carta trovoadas têm ID = 10;
    public GameObject carta10;
    public TMP_Text VidaTexto10;
    private float vida10;
    private float defesa10;
    public TMP_Text DefesaTexto10;
    private float ataque10;
    public TMP_Text AtaqueTexto10;
    private int cooldown10;


    //carta tornado têm ID = 11;
    public GameObject carta11;
    public TMP_Text VidaTexto11;
    private float vida11;
    private float defesa11;
    public TMP_Text DefesaTexto11;
    private float ataque11;
    public TMP_Text AtaqueTexto11;
    private int cooldown11;


    //carta volcão têm ID = 12;
    public GameObject carta12;
    public TMP_Text VidaTexto12;
    private float vida12;
    private float defesa12;
    public TMP_Text DefesaTexto12;
    private float ataque12;
    public TMP_Text AtaqueTexto12;
    private int cooldown12;


    private int cartas;


    //<--------------------------------------------------------------------------->

    //ao iniciar o jogo estes são os valores das stats
    //isto vai servir para depois podermos calcular os valores dos ataques de cada um dos lados (player e bot)

    private void Start()
    {
        cartas = 6;


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
        if (cooldown1 <= 0)
        {
            UseTsunami.SetActive(true);
        }
        else
        {

        }
    }

    //Se o player escolher usar a sua carta do terramoto a função é ativada
    public void PlayerTerramotoUse()
    {
        if (cooldown2 <= 0)
        {
            UseTerramoto.SetActive(true);
        }
        else
        {

        }
    }

    //Se o player escolher usar a sua carta do fogo a função é ativada
    public void PlayerFogoUse()
    {
        if (cooldown3 <= 0)
        {
            UseFogo.SetActive(true);
        }
        else
        {

        }
    }

    //Se o player escolher usar a sua carta do trevoadas a função é ativada
    public void PlayerTrevoadasUse()
    {
        if (cooldown4 <= 0)
        {
            UseTrevoada.SetActive(true);
        }
        else
        {

        }
    }

    //Se o player escolher usar a sua carta do tornado a função é ativada
    public void PlayerTornadoUse()
    {
        if (cooldown5 <= 0)
        {
            UseTornado.SetActive(true);
        }
        else
        {

        }
    }

    //Se o player escolher usar a sua carta do volcão a função é ativada
    public void PlayerVolcaoUse()
    {
        if (cooldown6 <= 0)
        {
            UseVolcao.SetActive(true);
        }
        else
        {

        }
    }

    //<-------------------------------REDUCE COOLDOWN-------------------------------------------->

    //ao clicar no use vão ser ativadas 2 funções, uma para atacar e outra para reduzir o cooldown das próprias cartas

    //a lógica nestas funções será: se o cooldown tiver acima de 0 então reduzir 1, caso contrário o cooldown continua igual a 0

    public void CooldownTsunami()
    {
        cooldown2 -= 1;
        cooldown3 -= 1;
        cooldown4 -= 1;
        cooldown5 -= 1;
        cooldown6 -= 1;
    }

    public void CooldownTerramoto()
    {
        cooldown1 -= 1;
        cooldown3 -= 1;
        cooldown4 -= 1;
        cooldown5 -= 1;
        cooldown6 -= 1;
    }

    public void CooldownFogo()
    {
        cooldown1 -= 1;
        cooldown2 -= 1;
        cooldown4 -= 1;
        cooldown5 -= 1;
        cooldown6 -= 1;
    }

    public void CooldownTrevoada()
    {
        cooldown1 -= 1;
        cooldown2 -= 1;
        cooldown3 -= 1;
        cooldown5 -= 1;
        cooldown6 -= 1;
    }

    public void CooldownTornado()
    {
        cooldown1 -= 1;
        cooldown2 -= 1;
        cooldown3 -= 1;
        cooldown4 -= 1;
        cooldown6 -= 1;
    }

    public void CooldownVolcao()
    {
        cooldown1 -= 1;
        cooldown2 -= 1;
        cooldown3 -= 1;
        cooldown4 -= 1;
        cooldown5 -= 1;
    }




    //<-------------------------------TSUNAMI PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami1()
    {
        vida7 -= (ataque1 * ataque1) / (ataque1 + defesa7);
        ataque7 -= 1;
        AtaqueTexto7.text = ataque7.ToString();
        int damageInInt7 = Mathf.RoundToInt(vida7);
        VidaTexto7.text = damageInInt7.ToString();
        UseTsunami.SetActive(false);
        cooldown1 = 5;
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto1()
    {
        vida8 -= (ataque1 * ataque1) / (ataque1 + defesa8);
        ataque8 -= 1;
        AtaqueTexto8.text = ataque8.ToString();
        int damageInInt8 = Mathf.RoundToInt(vida8);
        VidaTexto8.text = damageInInt8.ToString();
        UseTsunami.SetActive(false);
        cooldown1 = 5;
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo1()
    {
        vida9 -= (ataque1 * ataque1) / (ataque1 + defesa9);
        ataque9 -= 1;
        AtaqueTexto9.text = ataque9.ToString();
        int damageInInt9 = Mathf.RoundToInt(vida9);
        VidaTexto9.text = damageInInt9.ToString();
        UseTsunami.SetActive(false);
        cooldown1 = 5;
        
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada1()
    {
        vida10 -= (ataque1 * ataque1) / (ataque1 + defesa10);
        ataque10 -= 1;
        AtaqueTexto10.text = ataque10.ToString();
        int damageInInt10 = Mathf.RoundToInt(vida10);
        VidaTexto10.text = damageInInt10.ToString();
        UseTsunami.SetActive(false);
        cooldown1 = 5;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado1()
    {
        vida11 -= (ataque1 * ataque1) / (ataque1 + defesa11);
        ataque11 -= 1;
        AtaqueTexto11.text = ataque11.ToString();
        int damageInInt11 = Mathf.RoundToInt(vida11);
        VidaTexto11.text = damageInInt11.ToString();
        UseTsunami.SetActive(false);
        cooldown1 = 5;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao1()
    {
        vida12 -= (ataque1 * ataque1) / (ataque1 + defesa12);
        ataque12 -= 1;
        AtaqueTexto12.text = ataque12.ToString();
        int damageInInt12 = Mathf.RoundToInt(vida12);
        VidaTexto12.text = damageInInt12.ToString();
        UseTsunami.SetActive(false);
        cooldown1 = 5;
    }



    //<-------------------------------TERRAMOTO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami2()
    {
        vida7 -= (ataque2 * ataque2) / (ataque2 + defesa7);
        vida8 -= 1;
        vida9 -= 1;
        vida10 -= 1;
        vida11 -= 1;
        vida12 -= 1;
        int damageInInt7 = Mathf.RoundToInt(vida7);
        VidaTexto7.text = damageInInt7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto11.text = vida11.ToString();
        VidaTexto12.text = vida12.ToString();
        UseTerramoto.SetActive(false);
        cooldown2 = 4;
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto2()
    {
        vida8 -= (ataque2 * ataque2) / (ataque2 + defesa8);
        vida7 -= 1;
        vida9 -= 1;
        vida10 -= 1;
        vida11 -= 1;
        vida12 -= 1;
        int damageInInt8 = Mathf.RoundToInt(vida8);
        VidaTexto8.text = damageInInt8.ToString();
        VidaTexto7.text = vida7.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto11.text = vida11.ToString();
        VidaTexto12.text = vida12.ToString();
        UseTerramoto.SetActive(false);
        cooldown2 = 4;
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo2()
    {
        vida9 -= (ataque2 * ataque2) / (ataque2 + defesa9);
        vida7 -= 1;
        vida8 -= 1;
        vida10 -= 1;
        vida11 -= 1;
        vida12 -= 1;
        int damageInInt9 = Mathf.RoundToInt(vida9);
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto11.text = vida11.ToString();
        VidaTexto12.text = vida12.ToString();
        VidaTexto9.text = damageInInt9.ToString();
        UseTerramoto.SetActive(false);
        cooldown2 = 4;
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada2()
    {
        vida10 -= (ataque2 * ataque2) / (ataque2 + defesa10);
        vida7 -= 1;
        vida8 -= 1;
        vida9 -= 1;
        vida11 -= 1;
        vida12 -= 1;
        int damageInInt10 = Mathf.RoundToInt(vida10);
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto11.text = vida11.ToString();
        VidaTexto12.text = vida12.ToString();
        VidaTexto10.text = damageInInt10.ToString();
        UseTerramoto.SetActive(false);
        cooldown2 = 4;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado2()
    {
        vida11 -= (ataque2 * ataque2) / (ataque2 + defesa11);
        vida7 -= 1;
        vida8 -= 1;
        vida9 -= 1;
        vida10 -= 1;
        vida12 -= 1;
        int damageInInt11 = Mathf.RoundToInt(vida11);
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto12.text = vida12.ToString();
        VidaTexto11.text = damageInInt11.ToString();
        UseTerramoto.SetActive(false);
        cooldown2 = 4;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao2()
    {
        vida12 -= (ataque2 * ataque2) / (ataque2 + defesa12);
        vida7 -= 1;
        vida8 -= 1;
        vida9 -= 1;
        vida10 -= 1;
        vida11 -= 1;
        int damageInInt12 = Mathf.RoundToInt(vida12);
        VidaTexto12.text = damageInInt12.ToString();
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto11.text = vida11.ToString();
        UseTerramoto.SetActive(false);
        cooldown2 = 4;
    }


    //<-------------------------------FOGO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami3()
    {
        vida7 -= (ataque3 * ataque3) / (ataque3 + defesa7);
        vida8 -= 2;
        vida9 -= 2;
        vida10 -= 2;
        vida11 -= 2;
        vida12 -= 2;
        int damageInInt7 = Mathf.RoundToInt(vida7);
        VidaTexto12.text = vida12.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto11.text = vida11.ToString();
        VidaTexto7.text = damageInInt7.ToString();
        UseFogo.SetActive(false);
        cooldown3 = 6;
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto3()
    {
        vida8 -= (ataque3 * ataque3) / (ataque3 + defesa8);
        vida7 -= 2;
        vida9 -= 2;
        vida10 -= 2;
        vida11 -= 2;
        vida12 -= 2;
        int damageInInt8 = Mathf.RoundToInt(vida8);
        VidaTexto8.text = damageInInt8.ToString();
        VidaTexto12.text = vida12.ToString();
        VidaTexto7.text = vida7.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto11.text = vida11.ToString();
        UseFogo.SetActive(false);
        cooldown3 = 6;
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo3()
    {
        vida9 -= (ataque3 * ataque3) / (ataque3 + defesa9);
        vida7 -= 2;
        vida8 -= 2;
        vida10 -= 2;
        vida11 -= 2;
        vida12 -= 2;
        int damageInInt9 = Mathf.RoundToInt(vida9);
        VidaTexto9.text = damageInInt9.ToString();
        VidaTexto12.text = vida12.ToString();
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto10.text = vida10.ToString();
        VidaTexto11.text = vida11.ToString();
        UseFogo.SetActive(false);
        cooldown3 = 6;
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada3()
    {
        vida10 -= (ataque3 * ataque3) / (ataque3 + defesa10);
        vida7 -= 2;
        vida8 -= 2;
        vida9 -= 2;
        vida11 -= 2;
        vida12 -= 2;
        int damageInInt10 = Mathf.RoundToInt(vida10);
        VidaTexto10.text = damageInInt10.ToString();
        VidaTexto12.text = vida12.ToString();
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto11.text = vida11.ToString();
        UseFogo.SetActive(false);
        cooldown3 = 6;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado3()
    {
        vida11 -= (ataque3 * ataque3) / (ataque3 + defesa11);
        vida7 -= 2;
        vida8 -= 2;
        vida9 -= 2;
        vida10 -= 2;
        vida12 -= 2;
        int damageInInt11 = Mathf.RoundToInt(vida11);
        VidaTexto11.text = damageInInt11.ToString();
        VidaTexto12.text = vida12.ToString();
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        UseFogo.SetActive(false);
        cooldown3 = 6;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao3()
    {
        vida12 -= (ataque3 * ataque3) / (ataque3 + defesa12);
        vida7 -= 2;
        vida8 -= 2;
        vida9 -= 2;
        vida10 -= 2;
        vida11 -= 2;
        int damageInInt12 = Mathf.RoundToInt(vida12);
        VidaTexto12.text = damageInInt12.ToString();
        VidaTexto11.text = vida11.ToString();
        VidaTexto7.text = vida7.ToString();
        VidaTexto8.text = vida8.ToString();
        VidaTexto9.text = vida9.ToString();
        VidaTexto10.text = vida10.ToString();
        UseFogo.SetActive(false);
        cooldown3 = 6;
    }



    //<-------------------------------TROVOADA PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami4()
    {
        vida7 -= (ataque4 * ataque4) / (ataque4 + defesa7);
        vida2 += 1;
        vida3 += 1;
        vida1 += 1;
        vida5 += 1;
        vida6 += 1;
        int damageInInt7 = Mathf.RoundToInt(vida7);
        VidaTexto7.text = damageInInt7.ToString();
        VidaTexto1.text = vida1.ToString();
        VidaTexto2.text = vida2.ToString();
        VidaTexto3.text = vida3.ToString();
        VidaTexto5.text = vida5.ToString();
        VidaTexto6.text = vida6.ToString();
        UseTrevoada.SetActive(false);
        cooldown4 = 3;
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto4()
    {
        vida8 -= (ataque4 * ataque4) / (ataque4 + defesa8);
        vida2 += 1;
        vida3 += 1;
        vida1 += 1;
        vida5 += 1;
        vida6 += 1;
        int damageInInt8 = Mathf.RoundToInt(vida8);
        VidaTexto8.text = damageInInt8.ToString();
        VidaTexto1.text = vida1.ToString();
        VidaTexto2.text = vida2.ToString();
        VidaTexto3.text = vida3.ToString();
        VidaTexto5.text = vida5.ToString();
        VidaTexto6.text = vida6.ToString();
        UseTrevoada.SetActive(false);
        cooldown4 = 3;
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo4()
    {
        vida9 -= (ataque4 * ataque4) / (ataque4 + defesa9);
        vida2 += 1;
        vida3 += 1;
        vida1 += 1;
        vida5 += 1;
        vida6 += 1;
        int damageInInt9 = Mathf.RoundToInt(vida9);
        VidaTexto9.text = damageInInt9.ToString();
        VidaTexto1.text = vida1.ToString();
        VidaTexto2.text = vida2.ToString();
        VidaTexto3.text = vida3.ToString();
        VidaTexto5.text = vida5.ToString();
        VidaTexto6.text = vida6.ToString();
        UseTrevoada.SetActive(false);
        cooldown4 = 3;
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada4()
    {
        vida10 -= (ataque4 * ataque4) / (ataque4 + defesa10);
        vida2 += 1;
        vida3 += 1;
        vida1 += 1;
        vida5 += 1;
        vida6 += 1;
        int damageInInt10 = Mathf.RoundToInt(vida10);
        VidaTexto10.text = damageInInt10.ToString();
        VidaTexto1.text = vida1.ToString();
        VidaTexto2.text = vida2.ToString();
        VidaTexto3.text = vida3.ToString();
        VidaTexto5.text = vida5.ToString();
        VidaTexto6.text = vida6.ToString();
        UseTrevoada.SetActive(false);
        cooldown4 = 3;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado4()
    {
        vida11 -= (ataque4 * ataque4) / (ataque4 + defesa11);
        vida2 += 1;
        vida3 += 1;
        vida1 += 1;
        vida5 += 1;
        vida6 += 1;
        int damageInInt11 = Mathf.RoundToInt(vida11);
        VidaTexto11.text = damageInInt11.ToString();
        VidaTexto1.text = vida1.ToString();
        VidaTexto2.text = vida2.ToString();
        VidaTexto3.text = vida3.ToString();
        VidaTexto5.text = vida5.ToString();
        VidaTexto6.text = vida6.ToString();
        UseTrevoada.SetActive(false);
        cooldown4 = 3;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao4()
    {
        vida12 -= (ataque4 * ataque4) / (ataque4 + defesa12);
        vida2 += 1;
        vida3 += 1;
        vida1 += 1;
        vida5 += 1;
        vida6 += 1;
        int damageInInt12 = Mathf.RoundToInt(vida12);
        VidaTexto12.text = damageInInt12.ToString();
        VidaTexto1.text = vida1.ToString();
        VidaTexto2.text = vida2.ToString();
        VidaTexto3.text = vida3.ToString();
        VidaTexto5.text = vida5.ToString();
        VidaTexto6.text = vida6.ToString();
        UseTrevoada.SetActive(false);
        cooldown4 = 3;
    }


    //<-------------------------------TORNADO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami5()
    {
        vida7 -= (ataque5 * ataque5) / (ataque5 + defesa7);
        defesa7 -= 1;
        defesa8 -= 1;
        defesa9 -= 1;
        defesa10 -= 1;
        defesa11 -= 1;
        defesa12 -= 1;
        int damageInInt7 = Mathf.RoundToInt(vida7);
        VidaTexto7.text = damageInInt7.ToString();
        DefesaTexto7.text = defesa7.ToString();
        DefesaTexto8.text = defesa8.ToString();
        DefesaTexto9.text = defesa9.ToString();
        DefesaTexto10.text = defesa10.ToString();
        DefesaTexto11.text = defesa11.ToString();
        DefesaTexto12.text = defesa12.ToString();
        UseTornado.SetActive(false);
        cooldown5 = 7;
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto5()
    {
        vida8 -= (ataque5 * ataque5) / (ataque5 + defesa8);
        defesa7 -= 1;
        defesa8 -= 1;
        defesa9 -= 1;
        defesa10 -= 1;
        defesa11 -= 1;
        defesa12 -= 1;
        int damageInInt8 = Mathf.RoundToInt(vida8);
        VidaTexto8.text = damageInInt8.ToString();
        DefesaTexto7.text = defesa7.ToString();
        DefesaTexto8.text = defesa8.ToString();
        DefesaTexto9.text = defesa9.ToString();
        DefesaTexto10.text = defesa10.ToString();
        DefesaTexto11.text = defesa11.ToString();
        DefesaTexto12.text = defesa12.ToString();
        UseTornado.SetActive(false);
        cooldown5 = 7;
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo5()
    {
        vida9 -= (ataque5 * ataque5) / (ataque5 + defesa9);
        defesa7 -= 1;
        defesa8 -= 1;
        defesa9 -= 1;
        defesa10 -= 1;
        defesa11 -= 1;
        defesa12 -= 1;
        int damageInInt9 = Mathf.RoundToInt(vida9);
        VidaTexto9.text = damageInInt9.ToString();
        DefesaTexto7.text = defesa7.ToString();
        DefesaTexto8.text = defesa8.ToString();
        DefesaTexto9.text = defesa9.ToString();
        DefesaTexto10.text = defesa10.ToString();
        DefesaTexto11.text = defesa11.ToString();
        DefesaTexto12.text = defesa12.ToString();
        UseTornado.SetActive(false);
        cooldown5 = 7;
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada5()
    {
        vida10 -= (ataque5 * ataque5) / (ataque5 + defesa10);
        defesa7 -= 1;
        defesa8 -= 1;
        defesa9 -= 1;
        defesa10 -= 1;
        defesa11 -= 1;
        defesa12 -= 1;
        int damageInInt10 = Mathf.RoundToInt(vida10);
        VidaTexto10.text = damageInInt10.ToString();
        DefesaTexto7.text = defesa7.ToString();
        DefesaTexto8.text = defesa8.ToString();
        DefesaTexto9.text = defesa9.ToString();
        DefesaTexto10.text = defesa10.ToString();
        DefesaTexto11.text = defesa11.ToString();
        DefesaTexto12.text = defesa12.ToString();
        UseTornado.SetActive(false);
        cooldown5 = 7;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado5()
    {
        vida11 -= (ataque5 * ataque5) / (ataque5 + defesa11);
        defesa7 -= 1;
        defesa8 -= 1;
        defesa9 -= 1;
        defesa10 -= 1;
        defesa11 -= 1;
        defesa12 -= 1;
        int damageInInt11 = Mathf.RoundToInt(vida11);
        VidaTexto11.text = damageInInt11.ToString();
        DefesaTexto7.text = defesa7.ToString();
        DefesaTexto8.text = defesa8.ToString();
        DefesaTexto9.text = defesa9.ToString();
        DefesaTexto10.text = defesa10.ToString();
        DefesaTexto11.text = defesa11.ToString();
        DefesaTexto12.text = defesa12.ToString();
        UseTornado.SetActive(false);
        cooldown5 = 7;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao5()
    {
        vida12 -= (ataque5 * ataque5) / (ataque5 + defesa12);
        defesa7 -= 1;
        defesa8 -= 1;
        defesa9 -= 1;
        defesa10 -= 1;
        defesa11 -= 1;
        defesa12 -= 1;
        int damageInInt12 = Mathf.RoundToInt(vida12);
        VidaTexto12.text = damageInInt12.ToString();
        DefesaTexto7.text = defesa7.ToString();
        DefesaTexto8.text = defesa8.ToString();
        DefesaTexto9.text = defesa9.ToString();
        DefesaTexto10.text = defesa10.ToString();
        DefesaTexto11.text = defesa11.ToString();
        DefesaTexto12.text = defesa12.ToString();
        UseTornado.SetActive(false);
        cooldown5 = 7;
    }


    //<-------------------------------VOLCÃO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami6()
    {
        vida7 -= (ataque6 * ataque6) / (ataque6 + defesa7);
        int damageInInt7 = Mathf.RoundToInt(vida7);
        VidaTexto7.text = damageInInt7.ToString();
        UseVolcao.SetActive(false);
        cooldown6 = 8;
        cooldown7 = 2;
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto6()
    {
        vida8 -= (ataque6 * ataque6) / (ataque6 + defesa8);
        int damageInInt8 = Mathf.RoundToInt(vida8);
        VidaTexto8.text = damageInInt8.ToString();
        UseVolcao.SetActive(false);
        cooldown6 = 8;
        cooldown8 = 2;
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo6()
    {
        vida9 -= (ataque6 * ataque6) / (ataque6 + defesa9);
        int damageInInt9 = Mathf.RoundToInt(vida9);
        VidaTexto9.text = damageInInt9.ToString();
        UseVolcao.SetActive(false);
        cooldown6 = 8;
        cooldown9 = 2;
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada6()
    {
        vida10 -= (ataque6 * ataque6) / (ataque6 + defesa10);
        int damageInInt10 = Mathf.RoundToInt(vida10);
        VidaTexto10.text = damageInInt10.ToString();
        UseVolcao.SetActive(false);
        cooldown6 = 8;
        cooldown10 = 2;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado6()
    {
        vida11 -= (ataque6 * ataque6) / (ataque6 + defesa11);
        int damageInInt11 = Mathf.RoundToInt(vida11);
        VidaTexto11.text = damageInInt11.ToString();
        UseVolcao.SetActive(false);
        cooldown6 = 8;
        cooldown11 = 2;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao6()
    {
        vida12 -= (ataque6 * ataque6) / (ataque6 + defesa12);
        int damageInInt12 = Mathf.RoundToInt(vida12);
        VidaTexto12.text = damageInInt12.ToString();
        UseVolcao.SetActive(false);
        cooldown6 = 8;
        cooldown12 = 2;
    }

    


    private void Update()
    {
        if (cartas == 0)
        {
            SceneManager.LoadScene(3);
        }

        if(vida7 <= 0)
        {
            Object.Destroy(carta7);
            cartas -= 1;
        }

        if (vida8 <= 0)
        {
            Object.Destroy(carta8);
            cartas -= 1;
        }

        if (vida9 <= 0)
        {
            Object.Destroy(carta9);
            cartas -= 1;
        }

        if (vida10 <= 0)
        {
            Object.Destroy(carta10);
            cartas -= 1;
        }

        if (vida11 <= 0)
        {
            Object.Destroy(carta11);
            cartas -= 1;
        }

        if (vida12 <= 0)
        {
            Object.Destroy(carta12);
            cartas -= 1;
        }
    }
}
