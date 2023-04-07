using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula07list : MonoBehaviour
{
    //Aqui temos uma lista simples    
    /*public List<string> inimigos = new List<string>();

    void Start()
    {
        //Adicionar elementos no list
        inimigos.Add("Minion");
        inimigos.Add("Atirador");
        inimigos.Add("Guerreiro");
        inimigos.Add("Guarda");
    }*/


    //Aqui temos uma lista que armazena classes diferentes para cada item na lista
    [System.Serializable]
    public class Minion
    {
        public string nome;
        public int força;
        public int dano;
    }

    public List<Minion> Minions = new List<Minion>();

    void Start()
    {
        //declaro as instancias do objeto
        Minion Minion1 = new Minion();
        Minion1.nome = "Juriscreuza";
        Minion1.força = 10;
        Minion1.dano = 20;

        Minion Minion2 = new Minion();
        Minion2.nome = "Adalberto";
        Minion2.força = 5;
        Minion2.dano = 15;

        //Adiciono as instancias a list
        Minions.Add(Minion1);
        Minions.Add(Minion2);

        //Aqui removo uma instancia da lista
        Minions.Remove(Minion1);
    }
}
