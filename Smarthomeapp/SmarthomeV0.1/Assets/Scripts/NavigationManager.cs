using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationManager : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject bathroomCamera;
    public GameObject kitchenCamera;
    public GameObject bedroomCamera;
    public GameObject livingRoomCamera;
    public GameObject parametersPanel;
    public GameObject roomsPanel;
    public Text roomText;

    void Start()
    {
        mainCamera.SetActive(true);
        bathroomCamera.SetActive(false);
        kitchenCamera.SetActive(false);
        livingRoomCamera.SetActive(false);
        bedroomCamera.SetActive(false);
        parametersPanel.SetActive(false);
        roomsPanel.SetActive(true);
        roomText.text = "";
    }

    public void OnLivingRoomButtonClick()
    {
        mainCamera.SetActive(false);
        bathroomCamera.SetActive(false);
        kitchenCamera.SetActive(false);
        livingRoomCamera.SetActive(true);
        bedroomCamera.SetActive(false);
        parametersPanel.SetActive(true);
        roomsPanel.SetActive(false);
        roomText.text = "LIVING ROOM";
    }

    public void OnKitchenButtonClick()
    {
        mainCamera.SetActive(false);
        bathroomCamera.SetActive(false);
        kitchenCamera.SetActive(true);
        livingRoomCamera.SetActive(false);
        bedroomCamera.SetActive(false);
        parametersPanel.SetActive(true);
        roomsPanel.SetActive(false);
        roomText.text = "KITCHEN";
    }

    public void OnBathroomButtonClick()
    {
        mainCamera.SetActive(false);
        bathroomCamera.SetActive(true);
        kitchenCamera.SetActive(false);
        livingRoomCamera.SetActive(false);
        bedroomCamera.SetActive(false);
        parametersPanel.SetActive(true);
        roomsPanel.SetActive(false);
        roomText.text = "BATHROOM";
    }

    public void OnBedroomButtonClick()
    {
        mainCamera.SetActive(false);
        bathroomCamera.SetActive(false);
        kitchenCamera.SetActive(false);
        livingRoomCamera.SetActive(false);
        bedroomCamera.SetActive(true);
        parametersPanel.SetActive(true);
        roomsPanel.SetActive(false);
        roomText.text = "BEDROOM";
    }

    public void OnBackButtonClick()
    {
        mainCamera.SetActive(true);
        bathroomCamera.SetActive(false);
        kitchenCamera.SetActive(false);
        livingRoomCamera.SetActive(false);
        bedroomCamera.SetActive(false);
        parametersPanel.SetActive(false);
        roomsPanel.SetActive(true);
        roomText.text = "";
    }

}
