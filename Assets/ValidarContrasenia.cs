﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresousuario;
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
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña Incorrecta");
        }
    }

}
