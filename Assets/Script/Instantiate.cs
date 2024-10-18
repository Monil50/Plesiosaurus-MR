using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{ 
    public GameObject instantiateObj;
    public GameObject target;
    public Vector3 offset;
    public bool isOn;
   
    void Start()
    {
        
    }

   
    void Update()
    {
     
    }

    public void InstantiateOBJ()
    {
        if (!isOn)
        {
            //Vector3 pos = new Vector3(target.transform.position.x -0.15f, target.transform.position.y + 1f, target.transform.position.z + 0.8f);
            GameObject obj = Instantiate(instantiateObj, target.transform.position, target.transform.rotation);
            isOn = true;

            StartCoroutine(delay());
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
        isOn = false;
    }
}
