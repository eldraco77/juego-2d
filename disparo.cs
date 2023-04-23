using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{

    public GameObject bala;
    public GameObject gestorSonido;
    
    
    void Setup(){
     gestorSonido = GameObject.Find("AudioManager");

    }
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.X) == true){
        Instantiate(bala,new Vector2(transform.position.x,transform.position.y),transform.rotation);
       //gestorSonido.GetComponent<sonido>().disparoSE();
       this.GetComponentInParent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<sonido>().SonidoBala,1f);
       }
    }
}
