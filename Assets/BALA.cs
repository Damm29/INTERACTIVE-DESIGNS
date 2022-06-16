using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALA : MonoBehaviour
{
    public GameObject BALA;
    public GameObject ARMA;
    public float fuerzaproyectil = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown())
        {
            GameObject BALAins = instantrate(BALA, ARMA.transform.position, Quaternion.identity);
            BALAins.GetComponent<Rigidbody>().AddForce(ARMA.transform.forward'fuerzaproyectil');
            Destroy(BALAins.2.5f);
        }
    }
}
