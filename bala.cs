using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
       if(movimiento.DirecBala == true && movimiento.PararBala == false){
        transform.Translate(new Vector2(Time.deltaTime * 6,0));

       }

       if(movimiento.DirecBala == false && movimiento.PararBala == true){
        transform.Translate(new Vector2(-Time.deltaTime * 6,0));

       }
    }
}
