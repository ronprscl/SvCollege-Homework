using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACCont : MonoBehaviour
{
    public static bool isOn, isHeat;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }
    private void Update()
    {
        if (!isHeat)
            light.gameObject.SetActive(false);
        else
            light.gameObject.SetActive(true);
    }


}
