using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantasmita : MonoBehaviour
{
    public string clonBala;
    float SpeedEnemigo = 0.3f;
    float DistanciaPlayer = 4f;
    Vector3 posInicial;
    public GameObject player;
    public GameObject gestorSonido;
    //private AudioSource SonidoEnemigo;

    void Start(){

    player = GameObject.FindGameObjectWithTag("Player");
    posInicial = transform.position;
    //SonidoEnemigo = GetComponent<AudioSource>().SonidoBala();
    gestorSonido =  GameObject.Find("AudioManager");
    }

    void Update(){

    Vector3 Objetivo = posInicial;
    float distancia = Vector2.Distance(player.transform.position,transform.position);

       if(distancia < DistanciaPlayer){
        Objetivo = player.transform.position;

       }

       float VelocidadFija = SpeedEnemigo*Time.deltaTime;
       transform.position = Vector3.MoveTowards(transform.position, Objetivo, VelocidadFija);
       Debug.DrawLine(transform.position, Objetivo, Color.green);

    }

    void  OnTriggerEnter2D(Collider2D col){
    clonBala = col.gameObject.name;

    if(clonBala == "bala(Clone)"){
      //gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<sonido>().SonidoBala);
      Destroy(this.gameObject, 0.3f);
      principalScript.Enemigos++;

    }
    if(clonBala == "pj"){
        principalScript.Vida--;
        player.transform.position = new Vector2(0f,-0.83f);
        gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<sonido>().SonidoDead);
    }
   
    }
}
