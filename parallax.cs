using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public GameObject pj;
    public GameObject Nubes;
    public static string Direcpj;
    public float Vnube = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if(Direcpj == "derecha"){
        Vnube -= 0.01f;

       }
       
       if(Direcpj == "izquierda"){
        Vnube += 0.01f;

       }


       if(Direcpj == "parado"){
       Vnube = 0.0f;

       }
        Nubes.transform.Translate(Vnube*Time.deltaTime,0,0);
    }
}
