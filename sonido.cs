using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    public AudioClip bandaSonora;
    public AudioClip clipMenu;
    public  AudioClip SonidoBala;
    public AudioClip SonidoDead;
    public AudioClip tilin;
    public AudioSource Musica;
    public static GameObject Script2;
    
   
  /* void Awake(){
    DontDestroyOnLoad(this.gameObject);

    if(Script2 == null){
       Script2 = this.gameObject;
    } else(Script2 != null){
        DestroyObject(this.gameObject);
    }

   }*/
    void Start()
    {
        Musica = GetComponent<AudioSource>();
        Musica.clip = bandaSonora;
        Musica.loop = true;
        Musica.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void clicSE (){

        Musica.PlayOneShot(clipMenu, 1f);
    }

    public void deadSE (){
        Musica.PlayOneShot(SonidoDead, 1f);

    }

    public void disparoSE (){
        Musica.PlayOneShot(SonidoBala, 1f);

    }
    
     public void scoreSE (){
        Musica.PlayOneShot(tilin, 1f);

}
}