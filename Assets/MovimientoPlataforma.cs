using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public float velocidad = 2f;
    public float tiempoCambio = 3f; 
    [SerializeField] Vector3 direccion;
    private float timer;

    void Start()
    {       
        direccion = Vector3.right;
        timer = tiempoCambio;
    }

    void Update()
    {        
        transform.Translate(direccion * velocidad * Time.deltaTime);
        timer -= Time.deltaTime;        
        
        if (timer <= 0f)
        {            
            direccion = -direccion;
            timer = tiempoCambio;
        }
    }
}
