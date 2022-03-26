using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaatikonScripts : MonoBehaviour
{

    private float laskuri = 0f;

    private GameObject teksti = null;

    void Awake()
    {
        this.teksti = GameObject.Find("teksti");
        this.teksti.GetComponent<TextMesh>().color = Color.red;
        this.GetComponent<Rigidbody>().isKinematic = true;
    }

    void Start()
    {
        
    }


    void Update()
    {
        this.laskuri += Time.deltaTime;

        if(laskuri < 15f){
            this.GetComponent<Transform>().Rotate(100 * Time.deltaTime, 100 * Time.deltaTime, 100 * Time.deltaTime);

            this.teksti.GetComponent<TextMesh>().text = "Laskuri: " + laskuri;
        }
        else{
            this.GetComponent<Rigidbody>().isKinematic = false;

            this.teksti.GetComponent<TextMesh>().color = Color.blue;

            this.teksti.GetComponent<TextMesh>().text = "PUTOAA";
        }
    }
}
