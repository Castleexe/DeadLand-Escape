using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;

public class UI_Shop : MonoBehaviour {

    public Abilities abilities;

    private Transform container;
    private Transform shopItemTemplate;

    private void Awake() {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start() {
        CreateItemButton("Fire Rate", "addFireRate", 5, 0);
        Hide();
    }

    private void CreateItemButton(string itemName, string abilityName, int itemCost, int positionIndex) {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 90f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("nameText").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.GetComponent<Button_UI>().ClickFunc = () => {
            // Clicked on shop item button
            abilities.buyAbility(abilityName);
        };
    }
    public void Hide() {
        gameObject.SetActive(false);
    }
}
