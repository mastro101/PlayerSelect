using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class SelectCharacterMenu : MonoBehaviour
{
    [SerializeField]
    SelectCharacter selectCharacter;
    [SerializeField]
    Image currentCharacterImage;
    [SerializeField]
    TextMeshProUGUI NameText;
    GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        selectCharacter.changeCharacter = changeIcon;
    }

    void changeIcon()
    {
        currentCharacterImage.sprite = selectCharacter.currentPlayer.Icon;
        NameText.text = selectCharacter.currentPlayer.Name;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameManager.P1.Data = selectCharacter.currentPlayer;
        }
    }
}
