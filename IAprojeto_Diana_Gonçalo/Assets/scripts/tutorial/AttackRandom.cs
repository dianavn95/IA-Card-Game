using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

    //bot
    private int ValorIDB;
    
    //player
    private int ValorIDP;

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

    

    public void EscolherAtacar()
    {
        Dados();
        EscolherCarta();
    }


    public void Dados()
    {
        ValorIDB = Random.Range(7, 12);
        ValorIDP = Random.Range(1, 6);

        if (ValorIDB == 7)
        {
            ID7 = true;
        }

        if (ValorIDB == 1)
        {
            ID1 = true;
        }

        if (ValorIDB == 2)
        {
            ID2 = true;
        }

        if (ValorIDB == 4)
        {
            ID4 = true;
        }

        if (ValorIDB == 5)
        {
            ID5 = true;
        }

        if (ValorIDB == 6)
        {
            ID6 = true;
        }

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

    public void EscolherCarta()
    {
        if (ID1 && ID7 && cooldown1 <= 0)
        {
            AttackTsunami1();
            CooldownTsunami();
        }
        if (ID1 && ID8 && cooldown2 <= 0)
        {
            AttackTerramoto1();
            CooldownTerramoto();

        }
        if (ID1 && ID9 && cooldown3 <= 0)
        {
            AttackFogo1();
            CooldownFogo();
        }
        if (ID1 && ID10 && cooldown4 <= 0)
        {
            AttackTrevoada1();
            CooldownTrevoada();
        }
        if (ID1 && ID11 && cooldown5 <= 0)
        {
            AttackTornado1();
            CooldownTornado();
        }
        if (ID1 && ID12 && cooldown6 <= 0)
        {
            AttackVolcao1();
            CooldownVolcao();
        }




        if (ID2 && ID7 && cooldown1 <= 0)
        {
            AttackTsunami2();
            CooldownTsunami();
        }
        if (ID2 && ID8 && cooldown2 <= 0)
        {
            AttackTerramoto2();
            CooldownTerramoto();

        }
        if (ID2 && ID9 && cooldown3 <= 0)
        {
            AttackFogo2();
            CooldownFogo();
        }
        if (ID2 && ID10 && cooldown4 <= 0)
        {
            AttackTrevoada2();
            CooldownTrevoada();
        }
        if (ID2 && ID11 && cooldown5 <= 0)
        {
            AttackTornado2();
            CooldownTornado();
        }
        if (ID2 && ID12 && cooldown6 <= 0)
        {
            AttackVolcao2();
            CooldownVolcao();
        }





        if (ID3 && ID7 && cooldown1 <= 0)
        {
            AttackTsunami3();
            CooldownTsunami();
        }
        if (ID3 && ID8 && cooldown2 <= 0)
        {
            AttackTerramoto3();
            CooldownTerramoto();

        }
        if (ID3 && ID9 && cooldown3 <= 0)
        {
            AttackFogo3();
            CooldownFogo();
        }
        if (ID3 && ID10 && cooldown4 <= 0)
        {
            AttackTrevoada3();
            CooldownTrevoada();
        }
        if (ID3 && ID11 && cooldown5 <= 0)
        {
            AttackTornado3();
            CooldownTornado();
        }
        if (ID3 && ID12 && cooldown6 <= 0)
        {
            AttackVolcao3();
            CooldownVolcao();
        }







        if (ID4 && ID7 && cooldown1 <= 0)
        {
            AttackTsunami4();
            CooldownTsunami();
        }
        if (ID4 && ID8 && cooldown2 <= 0)
        {
            AttackTerramoto4();
            CooldownTerramoto();

        }
        if (ID4 && ID9 && cooldown3 <= 0)
        {
            AttackFogo4();
            CooldownFogo();
        }
        if (ID4 && ID10 && cooldown4 <= 0)
        {
            AttackTrevoada4();
            CooldownTrevoada();
        }
        if (ID4 && ID11 && cooldown5 <= 0)
        {
            AttackTornado4();
            CooldownTornado();
        }
        if (ID4 && ID12 && cooldown6 <= 0)
        {
            AttackVolcao4();
            CooldownVolcao();
        }





        if (ID5 && ID7 && cooldown1 <= 0)
        {
            AttackTsunami5();
            CooldownTsunami();
        }
        if (ID5 && ID8 && cooldown2 <= 0)
        {
            AttackTerramoto5();
            CooldownTerramoto();

        }
        if (ID5 && ID9 && cooldown3 <= 0)
        {
            AttackFogo5();
            CooldownFogo();
        }
        if (ID5 && ID10 && cooldown4 <= 0)
        {
            AttackTrevoada5();
            CooldownTrevoada();
        }
        if (ID5 && ID11 && cooldown5 <= 0)
        {
            AttackTornado5();
            CooldownTornado();
        }
        if (ID5 && ID12 && cooldown6 <= 0)
        {
            AttackVolcao5();
            CooldownVolcao();
        }






        if (ID6 && ID7 && cooldown1 <= 0)
        {
            AttackTsunami6();
            CooldownTsunami();
        }
        if (ID6 && ID8 && cooldown2 <= 0)
        {
            AttackTerramoto6();
            CooldownTerramoto();

        }
        if (ID6 && ID9 && cooldown3 <= 0)
        {
            AttackFogo6();
            CooldownFogo();
        }
        if (ID6 && ID10 && cooldown4 <= 0)
        {
            AttackTrevoada6();
            CooldownTrevoada();
        }
        if (ID6 && ID11 && cooldown5 <= 0)
        {
            AttackTornado6();
            CooldownTornado();
        }
        if (ID6 && ID12 && cooldown6 <= 0)
        {
            AttackVolcao6();
            CooldownVolcao();
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
        cooldown5 = 7;
    }


    //<-------------------------------VOLCÃO PLAYER-------------------------------------------->


    //função para atacar a carta do tsunami do bot
    public void AttackTsunami6()
    {
        vida7 -= (ataque6 * ataque6) / (ataque6 + defesa7);
        int damageInInt7 = Mathf.RoundToInt(vida7);
        VidaTexto7.text = damageInInt7.ToString();
        cooldown6 = 8;
        cooldown7 = 2;
    }

    //função para atacar a carta do terramoto do bot
    public void AttackTerramoto6()
    {
        vida8 -= (ataque6 * ataque6) / (ataque6 + defesa8);
        int damageInInt8 = Mathf.RoundToInt(vida8);
        VidaTexto8.text = damageInInt8.ToString();
        cooldown6 = 8;
        cooldown8 = 2;
    }

    //função para atacar a carta do fogo do bot
    public void AttackFogo6()
    {
        vida9 -= (ataque6 * ataque6) / (ataque6 + defesa9);
        int damageInInt9 = Mathf.RoundToInt(vida9);
        VidaTexto9.text = damageInInt9.ToString();
        cooldown6 = 8;
        cooldown9 = 2;
    }

    //função para atacar a carta das trevoadas do bot
    public void AttackTrevoada6()
    {
        vida10 -= (ataque6 * ataque6) / (ataque6 + defesa10);
        int damageInInt10 = Mathf.RoundToInt(vida10);
        VidaTexto10.text = damageInInt10.ToString();
        cooldown6 = 8;
        cooldown10 = 2;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackTornado6()
    {
        vida11 -= (ataque6 * ataque6) / (ataque6 + defesa11);
        int damageInInt11 = Mathf.RoundToInt(vida11);
        VidaTexto11.text = damageInInt11.ToString();
        cooldown6 = 8;
        cooldown11 = 2;
    }

    //função para atacar a carta do tsunami do bot
    public void AttackVolcao6()
    {
        vida12 -= (ataque6 * ataque6) / (ataque6 + defesa12);
        int damageInInt12 = Mathf.RoundToInt(vida12);
        VidaTexto12.text = damageInInt12.ToString();
        cooldown6 = 8;
        cooldown12 = 2;
    }



    private void Update()
    {
        EscolherAtacar();

        if (vida7 <= 0)
        {
            Object.Destroy(carta7);
        }

        if (vida8 <= 0)
        {
            Object.Destroy(carta8);
        }

        if (vida9 <= 0)
        {
            Object.Destroy(carta9);
        }

        if (vida10 <= 0)
        {
            Object.Destroy(carta10);
        }

        if (vida11 <= 0)
        {
            Object.Destroy(carta11);
        }

        if (vida12 <= 0)
        {
            Object.Destroy(carta12);
        }

    }
}
