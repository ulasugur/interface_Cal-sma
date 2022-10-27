using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                Iclickable clickable=hit.collider.GetComponent<Iclickable>();
                if (clickable != null)
                {
                    clickable.click();
                }
            }
        }
    }
}
