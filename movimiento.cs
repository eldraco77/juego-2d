using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    public static float Speed = 3f;
    public bool ActivaSalto = true;
    public float Salto = 5f;
    public Animator ControlAnimacion;
    public static bool DirecBala = false;
    public static bool PararBala = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (principalScript.Vida > 0){
            float H = Input.GetAxis("Horizontal")*Speed;
            H *= Time.deltaTime;
            transform.Translate (H,0,0);

           if(Input.GetKey(KeyCode.Space) && ActivaSalto == true){
            GetComponent<Rigidbody2D> (). AddForce (new Vector2 (0,Salto),ForceMode2D.Impulse);
            ActivaSalto = false;
           }

           if(Input.GetKeyDown(KeyCode.RightArrow)  ){
           transform.localScale = new Vector3 (1,1,1);
           Debug.Log("Right Arrow was pressed");
           ControlAnimacion.SetBool("activa camina",true);
           DirecBala = true;
           PararBala = true;
           parallax.Direcpj = "derecha";

           }

          if(Input.GetKeyUp(KeyCode.RightArrow)  ){
          ControlAnimacion.SetBool("activa camina",false);
          PararBala = false;
          parallax.Direcpj = "parado";
          }


         if(Input.GetKeyDown(KeyCode.LeftArrow)  ){
          transform.localScale = new Vector3 (-1,1,1);
          Debug.Log("Left Arrow was pressed");
          ControlAnimacion.SetBool("activa camina",true);
          DirecBala = false;
          PararBala = false;
          parallax.Direcpj = "izquierda";
          }
            if(Input.GetKeyUp(KeyCode.LeftArrow)  ){
          ControlAnimacion.SetBool("activa camina",false);
          PararBala = true;
          parallax.Direcpj = "parado";
         
          }
        }
    }

    void OnCollisionEnter2D(){

        ActivaSalto = true;
    }
}
