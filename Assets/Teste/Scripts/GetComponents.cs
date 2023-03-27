using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour
{
    private BoxCollider2D box;
    private Personagem player;

    public GameObject personagem;

    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        box.isTrigger = true;
        box.size = new Vector2(10,10);

        player = personagem.GetComponent<Personagem>();
        player.vida = 30;
        player.tipo = "Guerreiro";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
