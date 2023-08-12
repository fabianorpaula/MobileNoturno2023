using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private float tempo;
    public bool TipoDeMovimento = true;
    
    void Update()
    {
        tempo += Time.deltaTime;
        if(tempo > 0.001f)
        {
            if(TipoDeMovimento == true)
            {
                Mover();
            }
            
        }
        
        

    }

    void Mover()
    {

        if (Input.GetMouseButton(0))
        {
            //Captura a Posição do Mouse
            Vector3 destino = Input.mousePosition;
            //Corrigir Posição
            Vector3 desCorri = Camera.main.ScreenToWorldPoint(destino);
            //Destino Final Corrigido
            Vector3 dFinal = new Vector3(desCorri.x, -3f, 0);
            //Mover Objeto
            transform.position = Vector3.MoveTowards(transform.position, dFinal, 0.1f);

        }
    }


    public void MoverD()
    {
        if(TipoDeMovimento == false)
        {
            //Destino Final Corrigido
            Vector3 dFinal = new Vector3(2, -3f, 0);
            //Mover Objeto
            transform.position = Vector3.MoveTowards(transform.position, dFinal, 0.1f);
        }
       

    }
    public void MoverE()
    {
        if (TipoDeMovimento == false)
        {
            //Destino Final Corrigido
            Vector3 dFinal = new Vector3(-2, -3f, 0);
            //Mover Objeto
            transform.position = Vector3.MoveTowards(transform.position, dFinal, 0.1f);
        }

    }
}
