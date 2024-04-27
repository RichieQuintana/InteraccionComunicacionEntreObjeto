using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorObjeto : MonoBehaviour
{
    public GameObject objetoCambiarColor;
    public KeyCode teclaInteractuar = KeyCode.Space;
    public float distanciaMaxima = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teclaInteractuar))
        {
            // Calcula la distancia entre el jugador y el objeto
            float distancia = Vector3.Distance(transform.position, objetoCambiarColor.transform.position);

            // Verifica si el jugador está lo suficientemente cerca del objeto
            if (distancia <= distanciaMaxima)
            {
                // Cambia el color del objeto
                objetoCambiarColor.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
            else
            {
                Debug.Log("¡Estás demasiado lejos para cambiar el color!");
            }
        }
    }
}
