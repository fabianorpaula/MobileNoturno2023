using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private float tempo;
    
    void Update()
    {
        tempo += Time.deltaTime;
        if(tempo > 0.001f)
        {
            Mover();
        }
        
        

    }

    void Mover()
    {
        if (Input.GetMouseButton(0))
        {
            //Captura a Posi��o do Mouse
            Vector3 destino = Input.mousePosition;
            //Corrigir Posi��o
            Vector3 desCorri = Camera.main.ScreenToWorldPoint(destino);
            //Destino Final Corrigido
            Vector3 dFinal = new Vector3(desCorri.x, -3f, 0);
            //Mover Objeto
            transform.position = Vector3.MoveTowards(transform.position, dFinal, 0.1f);

        }
    }


    public void MoverD()
    {
        Debug.Log("Mandou Mover D");
    }
    public void MoverE()
    {
        Debug.Log("Mandou Mover E");
    }
}