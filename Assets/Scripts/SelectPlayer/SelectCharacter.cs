using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField]
    List<PlayerData> characters;
    public Action changeCharacter;
    PlayerData p;
    public PlayerData currentPlayer
    {
        get
        {
            return p;
        }
        set
        {
            p = value;
            changeCharacter?.Invoke();
        }
    }

    int n;
    int playerInList
    {
        get { return n; }
        set
        {
            n = value;
            if (n >= characters.Count)
                n = 0;
            else if (n < 0)
                n = characters.Count - 1;
        }
    }

    private void Awake()
    {
        playerInList = 0;
    }

    private void Start()
    {
        currentPlayer = characters[0];
    }

    public void NextCharacter()
    {
        playerInList++;
        currentPlayer = characters[playerInList];
    }

    public void PrevCharacter()
    {
        playerInList--;
        currentPlayer = characters[playerInList];
    }

}
