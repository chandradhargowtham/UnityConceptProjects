using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Vector3 destinationVector = new Vector3();
        
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0) && hit.transform.gameObject != GameObject.Find("Cube"))
        {
            
            
                destinationVector = hit.transform.position;
            
            GameObject.Find("Cube").transform.position = ray.GetPoint(10);
            
            

        }
        //
    }
}
