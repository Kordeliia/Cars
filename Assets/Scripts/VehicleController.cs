using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    //propiedades
    public static VehicleController sharedInstance;
    [Range(0, 200), SerializeField, Tooltip("Velocidad lineal máxima del coche")]
    private float speed = 5.0f;
    [Range(0,25), SerializeField, Tooltip("Velocidad de giro máxima del coche")]
    private float turnSpeed = 5f;
    private float horizontalInput;
    private float verticalInput;
    private void Awake()
    {
        sharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Movemos el coche hacia adelante
        // Espacio es igual a velocidad * Tiempo => E=V*t
        this.transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);
        this.transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
