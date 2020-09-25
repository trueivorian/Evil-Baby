using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{

    public GameObject[] buttons = new GameObject[] { };
    private int arrayLength;
    public float selectTime = 10f;
    public Material green;
    public Material red;
    private GameObject selectedButton;
    private GameObject deselectedButton;



    // Start is called before the first frame update
    void Start()
    {
        arrayLength = buttons.Length;
        StartCoroutine(ButtonCycle());

    }

    // Update is called once per frame
    void Update()
    {
        MaterialMaster();

        if(Input.GetKeyDown(KeyCode.Space))
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

    private void MaterialMaster()
    {
        selectedButton.GetComponent<MeshRenderer>().material = green;
        if (deselectedButton != null)
        {
            deselectedButton.GetComponent<MeshRenderer>().material = red;
        }
    }

    public void ButtonPressed()
    {
        print(selectedButton);
        StopAllCoroutines();
    }

}
