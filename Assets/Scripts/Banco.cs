using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    public int coracoes;
    public int dinheiro;

    private void Start()
    {
        dinheiro = RetornarDinheiro();
        coracoes = RetornarCoracao();
    }

    public void Comprar(int valor)
    {
        if(dinheiro>= valor)
        {
            dinheiro = dinheiro - (valor* (RetornarCoracao()+1));
            GuardaCoracoes();
            //Gravar o Novo Dinheiro
            PlayerPrefs.SetInt("Dinheiro", dinheiro);

        }
    }


    public void GuardaDinheiro(int moedas)
    {
        dinheiro = PlayerPrefs.GetInt("Dinheiro") + moedas;
        PlayerPrefs.SetInt("Dinheiro", dinheiro);
    }

    public int RetornarDinheiro()
    {
        
        return PlayerPrefs.GetInt("Dinheiro");
    }

    public void GuardaCoracoes()
    {
        coracoes = PlayerPrefs.GetInt("Coracao") + 1;
        PlayerPrefs.SetInt("Coracao", coracoes);
    }

    public int RetornarCoracao()
    {

        return PlayerPrefs.GetInt("Coracao");
    }
}
