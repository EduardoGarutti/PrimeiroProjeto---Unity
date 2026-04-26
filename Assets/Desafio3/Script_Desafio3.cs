using System;
using System.Collections.Generic;
using UnityEngine;

public class Script_Desafio3 : MonoBehaviour
{
    List<string> vogais = new List<string> { "a", "e", "i", "o", "u" };
    public string letra;
    void Start()
    {
        if (vogais.Contains(letra))
        {
            Debug.Log("é uma vogal");
        }
        else
        {
            Debug.Log("não é uma vogal");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
