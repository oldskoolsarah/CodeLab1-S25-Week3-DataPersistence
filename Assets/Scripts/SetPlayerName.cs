using UnityEngine;
using System;
using UnityEngine.UI;
using System.IO;

public class PlayerName: MonoBehaviour
{

    public Text nameText;
    private string playerName = "";

    string filePathPlayerName;
    const string DirName = "/Data/";
    const string FileName = DirName + "playername.txt";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!File.Exists(filePathPlayerName))
        {
            string dirLocation = Application.dataPath + DirName;

            if (!Directory.Exists(Application.dataPath + DirName))
            {
                Directory.CreateDirectory(dirLocation);
            }

            //File.Create(filePathHighScore).Dispose();
        }

        LoadPlayerName();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName(string input)
    {
        playerName = input;
    }


    public void SavePlayerName()
    {
        File.WriteAllText("playername.txt", playerName);
    }



    private void LoadPlayerName()
    {
        if (File.Exists("playername.txt"))
        {
            string loadedName = File.ReadAllText("playername.txt");
            playerName = loadedName;
        }
        else
        {
            nameText.text = "Enter your name: ";
        }
    }
}

