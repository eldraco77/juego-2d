using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{

    public GameObject gestorSonido;
    // Start is called before the first frame update
    void Setup()
    {
        gestorSonido = GameObject.Find("AudioManager");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (){
        principalScript.Score+=10;
       Destroy(this.gameObject, 0.5f);
        this.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<sonido>().tilin);
    }
}
