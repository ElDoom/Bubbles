using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMechanics : MonoBehaviour
{

    private Rigidbody2D rigidbody;
   
    [SerializeField]
    private float speed = 20.0f;

    public AudioClip touchSound;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = touchSound;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;
        //tiltText.text="Tilt X: "+tilt.y+" Y"+tilt.x+ " Z" + tilt.z;
        //tilt = Quaternion.Euler(90, 0, 0) * tilt;
        rigidbody.AddForce(tilt*speed);
        if (tilt.y > 0) rigidbody.AddForce(transform.up * speed);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Basket"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
            //Debug.Log("Touching");
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        rigidbody.AddForce(Vector3.up * speed, ForceMode2D.Impulse);
        audioSource.clip = touchSound;
        audioSource.Play();
        // Aquí puedes realizar cualquier acción que desees cuando se detecte el toque.
    }

}
