using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    [SerializeField] private GameObject wall1;
    [SerializeField] private GameObject wall2;
    [SerializeField] private GameObject wall3;
    [SerializeField] private GameObject wall4;
    [SerializeField] private GameObject wall5;
    [SerializeField] private GameObject wall6;
    [SerializeField] private GameObject wall7;
    [SerializeField] private GameObject wall8;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gazer;
    [SerializeField] private GameObject skelet;
    [SerializeField] private GameObject exit;

    private const string FLOOR = "0";
    private const string WALL1 = "1";
    private const string WALL2 = "2";
    private const string WALL3 = "3";
    private const string WALL4 = "4";
    private const string WALL5 = "5";
    private const string WALL6 = "6";
    private const string WALL7 = "7";
    private const string WALL8 = "8";
    private const string PLAYER = "P";
    private const string GAZER = "G";
    private const string SKELET = "S";
    private const string EXIT = "X";

    string [] lines;
    string myFilePath, fileName;

    void Start()
    {
        fileName = "map.txt";
        myFilePath = Application.dataPath + "/Scripts/GenerateLevel/Prefab_txt/" + fileName;

        string[][] matrix = CreateMatrix(myFilePath);
        Load(matrix);
    }

    private void Load(string[][] matrix){
        Debug.Log(matrix.Length-5);
        Debug.Log(matrix[0].Length-2);
        for (int y = 0; y < matrix.Length-2; y++) {
            for (int x = 0; x < matrix[0].Length-1; x++) {

                switch (matrix[y][x]){
                    case FLOOR:
                        Instantiate(floor, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL1:
                        Instantiate(wall1, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL2:
                        Instantiate(wall2, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL3:
                        Instantiate(wall3, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL4:
                        Instantiate(wall4, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL5:
                        Instantiate(wall5, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL6:
                        Instantiate(wall6, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL7:
                        Instantiate(wall7, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case WALL8:
                        Instantiate(wall8, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case PLAYER:
                        Instantiate(floor, new Vector2(x, -y), Quaternion.identity);
                        Instantiate(player, new Vector2(x, -y), Quaternion.identity);                    
                        break;
                    case SKELET:
                        Instantiate(floor, new Vector2(x, -y), Quaternion.identity);
                        Instantiate(skelet, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case GAZER:
                        Instantiate(floor, new Vector2(x, -y), Quaternion.identity);
                        Instantiate(gazer, new Vector2(x, -y), Quaternion.identity);
                        break;
                    case EXIT:
                        Instantiate(floor, new Vector2(x, -y), Quaternion.identity);
                        Instantiate(exit, new Vector2(x, -y), Quaternion.identity);
                        break;
                }
            }
        }
    }

    private string[][] CreateMatrix(string txtPath){
        string text = System.IO.File.ReadAllText(txtPath);
        string[] lines = Regex.Split(text, "\r\n");
        int rows = lines.Length;
        
        string[][] levelBase = new string[rows][];
        for (int i = 0; i < lines.Length; i++)  {
            string[] stringsOfLine = Regex.Split(lines[i], "");
            levelBase[i] = stringsOfLine;
        }
        return levelBase;
    }
}
