using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula05while : MonoBehaviour
{
    public int moedas = 100;
    public int vidas = 10;
    // Start is called before the first frame update
    void Start()
    {
        while (moedas < 1000)
        {
            Debug.Log("Sua quantidade de moedas é: " +moedas);
            moedas += 50;
        }

        do
        {
            Debug.Log("Sua quantidade de vidas é: " +vidas);
            vidas += 5;
        } while (vidas <= 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
