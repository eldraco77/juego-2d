using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pozo : MonoBehaviour
{

    public GameObject pj;
   
    public GameObject gestorSonido;
    
    
    void Setup(){
    
     gestorSonido = GameObject.Find("AudioManager");
    }

    

    void OnTriggerEnter2D(){
     Debug.Log("Has muerto");
     principalScript.Vida--;
     pj.transform.position = new Vector2(0f,-0.83f);
     gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<sonido>().SonidoDead);
     
    }
}
