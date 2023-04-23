using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cámara : MonoBehaviour
{
    public Transform pj;
    public float dondepj;
    public float dondepjY;
    
    // Update is called once per frame
    void Update()
    {
        dondepj = pj.transform.position.x;
        dondepjY = pj.transform.position.y;
        transform.position = new Vector3(dondepj,dondepjY,-10);
    }
}
