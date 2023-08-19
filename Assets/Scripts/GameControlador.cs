using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlador : MonoBehaviour
{

    public float pontos;
    public int vidas = 3;
    private bool gameState = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DarPontos(int valorX)
    {
        pontos = pontos + valorX;
    }

    public float MostrarPontos()
    {
        return pontos;
    }

    public void SofreuDano()
    {
        vidas--;
        if(vidas < 1)
        {
            Morrer();
        }
    }

    public string MostrarVidas()
    {
        return vidas.ToString();
    }

    public void Morrer()
    {
        Time.timeScale = 0;
        gameState = false;
    }

    public bool InformaEstado()
    {
        return gameState;
    }
}
