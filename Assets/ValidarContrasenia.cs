using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresousuario;
    public Text textomsj;
    public GameObject cartelitomsj;
    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia()
    {
        contraseniaUsuario = ingresousuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }

}
