using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasandoArrays : MonoBehaviour
{
    //Los arrays son colecciones de elementos del mismo tipo
    // Estamos creando un array con una longitud concreta pero con valores por defecto
    int[] ranking = new int[5];
    //Estamos creando un array con una longitud concreta y valores concretos des del principio
    int[] topTres = new int[] { 3, 5, 7 };

    // Start is called before the first frame update
    void Start()
    {

        //para acceder a los elementos del array lo hacemos des de su posición

        int first = ranking[0];

        // también podemos modificar elementos dentro del array a través de su posición

        ranking[1] = 125;

        int arrayLength = topTres.Length;

        int pos = 8;
        //De esta manera nos aseguramos que no nos den errores como out of range
        if(pos >= 0 && pos < topTres.Length)
        {
        int someNumber = topTres[pos];
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
