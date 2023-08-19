using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlador : MonoBehaviour
{

    public float pontos;
    public int vidas = 3;
    private bool gameState = true;
    public GameObject Chance;

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
        Chance.SetActive(true);
    }

    public bool InformaEstado()
    {
        return gameState;
    }

    public void MaisUmaChance()
    {
        vidas = 1;
        Time.timeScale = 1;
        gameState = true;
        Chance.SetActive(false);

    } 

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
