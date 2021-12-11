using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSelection : MonoBehaviour
{
    selectionDictionary selectedTable;
    RaycastHit hit;

    bool dragSelect;

    Vector3 p1;
    Vector3 p2;

    // Start is called before the first frame update
    void Start()
    {
        selectedTable = GetComponent<selectionDictionary>();
        dragSelect = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            p1 = Input.mousePosition;
            Debug.Log("p1 Loged");
        }
        if(Input.GetMouseButton(0))
        {
            if((p1 - Input.mousePosition).magnitude > 40)
            {
                dragSelect = true;
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            if(dragSelect == false)
            {
                Ray ray = Camera.main.ScreenPointToRay(p1);
                if(Physics.Raycast(ray,out hit, 50000.0f))
                {
                    if(Input.GetKeyDown(KeyCode.LeftShift))
                    {
                        selectedTable.addSelected(hit.transform.gameObject);
                    }
                    else
                    {
                        selectedTable.deselectAll();
                        selectedTable.addSelected(hit.transform.gameObject);
                    }
                }
                else
                {
                    if(Input.GetKey(KeyCode.LeftShift))
                    {

                    }
                    else
                    {
                        selectedTable.deselectAll();
                    }
                }
            }
        }
    }
}
