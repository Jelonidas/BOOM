using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Pobierz stan kontolera
        float x = Input.GetAxis("Horizontal");
        //docelowy ruch poziomo lewo/prawo
        Vector3 movement = Vector3.right * Time.deltaTime * x;
        //Pobierz stan kontolera Pion
        float y = Input.GetAxis("Vertical");
        movement += Vector3.forward * y * Time.deltaTime;
        //normalizacja ruchu po skosie
        movement = movement.normalized;
        //na³ó¿ zmianê an ruch gracza
        movement *= moveSpeed;
        transform.position += movement;
        
    }
}
