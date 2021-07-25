using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInformation : MonoBehaviour
{
    public Text name, isOn, mode, additionalInfo;
    public Canvas canvas;
    bool isRaiseAlpha, isLowerAlpha;
    public GameObject player, couchSpot, livingRoomOneSpot, BRSpotOne;
    Vector3 playerStartPos; Quaternion playerRot;
    // Start is called before the first frame update
    void Start()
    {
        Starter();
        playerStartPos = player.transform.position;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isRaiseAlpha)
            canvas.GetComponent<CanvasGroup>().alpha += 0.02f;
        else if(isLowerAlpha)
            canvas.GetComponent<CanvasGroup>().alpha -= 0.02f;
    }
    public void ShowInfo(string item)
    {
        isRaiseAlpha = true;
        isLowerAlpha = false;

        if(item == "AC")
        {
            name.text = "Air Conditioner";
            isOn.text = "Power on: " + ACCont.isOn.ToString();
            if (ACCont.isHeat)
                mode.text = "Heat mode";
            else
                mode.text = "Cold mode";
            additionalInfo.text = "";
        }
        else if(item == "Lamp")
        {
            name.text = "Led ceiling lamp";
            isOn.text = "Power on: " + LampCont.isOn.ToString();
            mode.text = "";
            additionalInfo.text = "";
        }
        else if(item == "TV")
        {
            name.text = "Sony TV";
            isOn.text = "Power on: " + TVCont.isOn.ToString();
            mode.text = "";
            additionalInfo.text = "Look at remote to toggle power off/ on";
        }


    }
    public void HideInfo()
    {
        isRaiseAlpha = false;
        isLowerAlpha = true;
    }
    void Starter()
    {
        canvas.GetComponent<CanvasGroup>().alpha = 0;
    }
    public void GoToPoint(string input)
    {
        if (input == "Couch")
            player.transform.position = couchSpot.transform.position;
        else if (input == "Remote")
            TVCont.isOn = !TVCont.isOn;
        else if (input == "ACToggle")
            ACCont.isHeat = !ACCont.isHeat;
        else if (input == "Entrance")
            player.transform.position = playerStartPos;
        else if (input == "DoorLR")
            player.transform.position = new Vector3(BRSpotOne.transform.position.x -5, BRSpotOne.transform.position.y -1, BRSpotOne.transform.position.z);
    }
    
    
}
