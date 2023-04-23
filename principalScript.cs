using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class principalScript : MonoBehaviour
{
    public static int Score = 0;
    public static int Vida = 3;
    public static int Enemigos = 0;
    public GUISkin Miskin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     /* void Update()
    {
        Debug.Log("Vida " +Vida);
        Debug.Log("Score " +Score);
        Debug.Log("Enemigos " +Enemigos);
    } */
   
    void OnGUI(){
        GUI.skin = Miskin;
        GUI.Label(new Rect(20,20,100,80),Vida.ToString(),"estilo");
        GUI.Label(new Rect(100,20,100,80),Score.ToString(),"estilo");
        GUI.Label(new Rect(180,20,100,80),Enemigos.ToString(),"estilo");
    }





}
