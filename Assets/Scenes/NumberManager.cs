using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI buttonText1;
    [SerializeField] TextMeshProUGUI buttonText2;
    [SerializeField] TextMeshProUGUI buttonText3;
    [SerializeField] TextMeshProUGUI buttonText4;
    [SerializeField] TextMeshProUGUI buttonText5;
    [SerializeField] TextMeshProUGUI buttonText6;
    [SerializeField] TextMeshProUGUI buttonText7;
    [SerializeField] TextMeshProUGUI buttonText8;
    [SerializeField] TextMeshProUGUI buttonText9;
    [SerializeField] TextMeshProUGUI buttonText10;
    [SerializeField] TextMeshProUGUI buttonText11;
    [SerializeField] TextMeshProUGUI buttonText12;
    [SerializeField] TextMeshProUGUI buttonText13;
    [SerializeField] TextMeshProUGUI buttonText14;
    [SerializeField] TextMeshProUGUI buttonText15;
    [SerializeField] TextMeshProUGUI buttonText16;
    TextMeshProUGUI[] buttonTexts;
    [SerializeField] Button maxButton;
    [SerializeField] Button minButton;
    [SerializeField] Button sumButton;
    Button[] modeButtons;
    int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
    // mode : max, min, sum
    int[] modeBoolean = {0, 0, 0};

    // Start is called before the first frame update
    void Start() {
        buttonTexts = new TextMeshProUGUI[] {buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10, buttonText11, buttonText12, buttonText13, buttonText14, buttonText15, buttonText16};
        modeButtons = new Button[] {maxButton, minButton, sumButton};
    }

    // Update is called once per frame
    void Update() {
    }

    public void clickModeButton(int modeNumber) {
        if (modeBoolean[modeNumber] == 0) {
            for (int i = 0; i < modeBoolean.Length; i++) {
                modeBoolean[i] = 0;
                modeButtons[i].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            modeBoolean[modeNumber] = 1;
            modeButtons[modeNumber].GetComponent<Image>().color = new Color32(255, 100, 100, 255);
        } else {
            modeBoolean[modeNumber] = 0;
            modeButtons[modeNumber].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
}
