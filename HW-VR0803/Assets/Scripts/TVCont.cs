using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVCont : MonoBehaviour
{
    public static bool isOn;
    Vector3 startPos, movePos;
    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
        startPos = transform.position;
        movePos = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
        
    }
    private void Update()
    {
        if (!isOn)
        {
            Debug.Log("logdahsigh");
            transform.position = movePos;
        }
        else
        {
            transform.position = startPos;
        }
            
    }


}
