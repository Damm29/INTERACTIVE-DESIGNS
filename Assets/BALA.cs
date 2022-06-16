using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALA : MonoBehaviour
{
    public GameObject BALAS;
    public GameObject ARMA;
    public float fuerzaproyectil = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject BalaIns = Instantiate(BALAS, ARMA.transform.position, Quaternion.identity);
            BalaIns.GetComponent<Rigidbody>().AddForce(ARMA.transform.forward * fuerzaproyectil);
            Destroy(BalaIns, 2.5f);
        }
    }
}
