using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boliche : MonoBehaviour
{
    public int valor = 0;
    private GameControlador GC;

    private void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControlador>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Pinos")
        {
            GC.DarPontos(valor);
            Destroy(this.gameObject);
            
        }

    }

}
