using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula08GetComponent : MonoBehaviour
{

    private BoxCollider2D box;
    private Aula08Personagem player;

    //caso eu queira manipular o componente em outro objeto
    public GameObject personagemExterno;

    // Start is called before the first frame update
    void Start()
    {
        //a variavel box recebe o componente BoxCollider2D
        box = GetComponent<BoxCollider2D>();
        //aqui posso manipular o componente BoxCollider2D através do script
        box.isTrigger = true;
        box.size = new Vector2(10,10);


        //aqui posso pegar o script Personagem como um componente e também posso alterar as informações no mesmo
        player = GetComponent<Aula08Personagem>();
        player.vida = 30;
        player.tipo = "Atirador";

        //Alterar dados de um componente em um objeto externo
        player = personagemExterno.GetComponent<Aula08Personagem>();
        player.vida = 25;
        player.tipo = "Espadachim";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
