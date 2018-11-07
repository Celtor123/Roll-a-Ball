using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movemento : MonoBehaviour { 
    public float velocidad;
    private Rigidbody rb;
    private int count;
    public Text contador;
    public Text ganador;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setcontador();
        ganador.text = "";
    }
    void FixedUpdate()
    {
        float movhorizontal=Input.GetAxis("Horizontal");
        float movvertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movhorizontal,0.0f,movvertical);
        rb.AddForce(movimiento *velocidad);
    }
    void OnTriggerEnter(Collider other)
    {
     if(other.gameObject.CompareTag("Pick_UP"))
        {
            other.gameObject.SetActive(false);
            count = count+1;
            setcontador();
        } 

    }
    void setcontador()
    {
        contador.text = "Contando " + count.ToString();
        if(count >= 8)
        {
            ganador.text = "Ganaste, EN_HORA_BUENA";
        }
    }
}
