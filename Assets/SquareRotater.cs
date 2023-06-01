using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareRotater : MonoBehaviour
{

    

    public float moveSpeed = 5f;
    public float maxX = 5f;
    public float maxY = 5f;
    void Start()
    {
       //Rigo rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                //Debug.Log("Se detectó un toque (tap)");

                // Aquí puedes realizar acciones adicionales en respuesta al toque
                // Generar una posición aleatoria dentro del rango especificado
                Vector2 randomPosition = new Vector2(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY));

                // Mover el objeto hacia la posición aleatoria
                gameObject.transform.position = randomPosition;
            }
        }
    }
}
