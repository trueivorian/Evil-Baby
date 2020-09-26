using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{

    public GameObject[] buttons = new GameObject[] { }; // An array of the buttons cycled through in the option panel
    public float selectTime = 10f; // The length of time given for the player to select a button

    private int arrayLength;
    private GameObject selectedButton;
    private GameObject deselectedButton;



    // Start is called before the first frame update
    void Start()
    {
        arrayLength = buttons.Length;

        for(int i=0; i<arrayLength; i++)
        {
            buttons[i].GetComponent<Image>().color = new Color32(101, 170, 219, 255);
        }

        StartCoroutine(ButtonCycle());

    }

    // Update is called once per frame
    void Update()
    {
        ChangeButtonColour();

        if(Input.anyKeyDown)
        {
            ButtonPressed();
        }
    }



    IEnumerator ButtonCycle()
    {

        for (int i = 0; i < arrayLength; i++)
        {
            selectedButton = buttons[i];

            yield return new WaitForSeconds(selectTime);
            if(i == arrayLength-1 )
            {
                i = -1;
            }
            deselectedButton = selectedButton;

        }
    }

    private void ChangeButtonColour()
    {
        selectedButton.GetComponent<Image>().color = new Color32(250, 203, 53, 255);
        if (deselectedButton != null)
        {
            deselectedButton.GetComponent<Image>().color = new Color32(101, 170, 219, 255);
        }
    }

    public void ButtonPressed()
    {
        print(selectedButton);
        StopAllCoroutines();
    }

}
