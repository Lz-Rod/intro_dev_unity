using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula09Personagem : MonoBehaviour
{
    public int Vidas;
    // Start is called before the first frame update
    void Start()
    {
        //aqui eu chamo o método atacar
        Atacar();
        PerdeuVida(30);
        AumentarVida();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            PerdeuVida(100);
        }
        
    }

    //método privado que faz o personagem atacar e só pode ser chamado dentro desse script
    void Atacar()
    {
        Debug.Log("Personagem Atacou!");
    }

    //método publico que movimenta o personagem e pode ser chamado dentro de qualquer script
    public void PerdeuVida(int ValorVida)
    {
        Vidas -= ValorVida;
        Debug.Log(Vidas);

    }

    //método do tipo int que retorna um valor inteiro
    int AumentarVida()
    {
        Vidas = 10;
        //é necessario usar o return sempre que o metodo é do tipo que retorna algo como float ou int
        return Vidas;
    }
}
