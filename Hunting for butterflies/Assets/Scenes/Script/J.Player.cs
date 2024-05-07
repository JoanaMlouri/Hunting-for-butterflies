using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Velocidade de movimento do personagem
    public float velocidadeMovimento = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtém a entrada do teclado para mover o personagem
        float movimentoHorizontal = Input.GetAxis("Horizontal"); 

        // Calcula o movimento
        Vector3 movimento = new Vector3(movimentoHorizontal, 0f, 0f) * velocidadeMovimento * Time.deltaTime;

        // Aplica o movimento ao personagem
        transform.Translate(movimento);
    }
}
