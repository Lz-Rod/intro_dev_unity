using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula06array : MonoBehaviour
{

    public int[] numeros = {1, 2, 3};
    public int[] arrayVazio;

    // Start is called before the first frame update
    void Start()
    {
        // aqui defino o tamanho do array
        arrayVazio = new int[7];
        // aqui eu acesso as posições do array e adiciono os valores
        arrayVazio[0] = 15;
        arrayVazio[5] = 667;
        arrayVazio[2] = 3;

        //aqui irá imprimir pelo debug os valores adicionados no array vazio

        foreach (int valorNumero in arrayVazio)
        {
            Debug.Log(valorNumero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
