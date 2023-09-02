using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaCenas : MonoBehaviour
{
   

    public void MudaCena(int numeroCena)
    {
        SceneManager.LoadScene(numeroCena);
    }

}
