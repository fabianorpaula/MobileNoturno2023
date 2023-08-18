using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlador : MonoBehaviour
{

    public float pontos;
    public int vidas = 3;

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
    }

    public string MostrarVidas()
    {
        return vidas.ToString();
    }
}
