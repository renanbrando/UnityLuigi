using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    public float speed = 1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //movimento um objeto na tela
        //transform.Translate(5.0f * Time.deltaTime, 0.0f, 0.0f);
        //transform.Translate(Vector2.up * 5.0f * Time.deltaTime);

        //tem que ser em 3d por casa do z
        //por frame e não por ciclos (Time.deltaTime)
        //transform.Rotate (Vector3.back * velocidade * Time.deltaTime);

        //pegar os direcionais
        //print(Input.GetAxis("Horizontal"));

        //GetAxis retorna float

        float move_x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move_x, 0.0f, 0.0f);

        float move_y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0.0f, move_x, 0.0f);

        //Input com retorno booleano
        if (Input.GetButtonDown("Jump"))
        {
            transform.position = Vector2.zero;
        }

    }
}