using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    // Start is called before the first frame update
    public int edadUsuario;
    public Text Mi_texto;

    void Start()
    {
       if(edadUsuario >= 18)
        {
            Mi_texto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            Mi_texto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
