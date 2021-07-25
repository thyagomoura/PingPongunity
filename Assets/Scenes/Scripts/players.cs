using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class players : MonoBehaviour
{

    public float velocidadeDoJogador;
    public bool jogador1;

    public float yMinimo;
    public float yMaximo;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (jogador1 == true)
        {
            MovimentoDoJogador1();
        }

        if (jogador1 == false)
        {
            MovimentoDoJogador2();
        }
    }

    public void MovimentoDoJogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        if (Input.GetKey(KeyCode.W))
        {
            //movimentar para cima apertando w do teclado
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //movimentar para baixo apertando S do teclado
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }

    }

    public void MovimentoDoJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //movimentar para cima apertando w do teclado
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //movimentar para baixo apertando S do teclado
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
}
