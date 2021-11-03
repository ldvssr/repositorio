using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste_script : MonoBehaviour
{

    //BoxCollider _boxCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Objeto iniciado");
        //GetComponent<Renderer>().enabled = false;
        //var componente = gameObject.AddComponent<BoxCollider>();
        /*
         * EXIGE MUITO PROCESSAMENTO
         * GetComponent<Collider>().isTrigger = true;
         * USAR O CÓDIGO EM DIANTE EM VEZ DISSO         * 
         */
         //_boxCollider = GetComponent <BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Objeto atualizado");
        //_boxCollider.isTrigger = true;
    }
}
