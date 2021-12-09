using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    private string path;
    private string now;
    private string[,] allScores=new string[12,2];
    public string newScore;
    public static string difficulte="easy";

    public TMP_Text pos1;
    public TMP_Text pos2;
    public TMP_Text pos3;
    public TMP_Text pos4;
    public TMP_Text pos5;
    public TMP_Text pos6;
    public TMP_Text pos7;
    public TMP_Text pos8;
    public TMP_Text pos9;
    public TMP_Text pos10;
    public TMP_Text pos11;
    public TMP_Text pos12;

    void Start()
    {
        //string now = Convert.ToString((int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        path = Directory.GetCurrentDirectory() + @"\Score\" + "Score.csv";
        ReadCSVFile();
        if (SceneManager.GetActiveScene().name == "ScoreScene"){
 
            WriteScoreBoard();
        }

    }
    public void NewScore(){
        newScore=HUDController.instance.EndGame().ToString();
        CheckScore();
    }
    private void CheckScore()
    {
        for (int i=0;i<12;i++){
            if (allScores[i,0]==difficulte){
                var newdata1 = newScore.Split(':');
                var newdata2 = allScores[i,1].Split(':');
                if (Int32.Parse(newdata1[0]+newdata1[1]+newdata1[2])<Int32.Parse(newdata2[0]+newdata2[1]+newdata2[2])){
                    string temp=allScores[i,1];
                    allScores[i,1]=newScore;
                    newScore=temp;
                }
            }
        }
        WriteCSVFile();
    }
    private void ReadCSVFile(){
        StreamReader streamReader = new StreamReader(path);
        bool endOfFile = false;
        int i=0;
        while(!endOfFile){
            string data_string = streamReader.ReadLine();
            if (data_string==null){
                endOfFile=true;
                break;
            }
            var data_values = data_string.Split(',');
            for (int j=0; j<2;j++){
                allScores[i,j]=data_values[j].ToString();
            }
            i++;
        }
        streamReader.Close();
        
    }

    private void WriteCSVFile(){
        StreamWriter streamWriter = new StreamWriter(path);
        for (int i=0;i<12;i++){
            streamWriter.WriteLine(allScores[i,0]+','+allScores[i,1]);
        }
        streamWriter.Close();
        
    }
    public void MenuButton(){
        SceneManager.LoadScene("MenuScene"); 
    }
    private void WriteScoreBoard(){
        pos1.text=allScores[0,1];
        pos2.text=allScores[1,1];
        pos3.text=allScores[2,1];
        pos4.text=allScores[3,1];
        pos5.text=allScores[4,1];
        pos6.text=allScores[5,1];
        pos7.text=allScores[6,1];
        pos8.text=allScores[7,1];
        pos9.text=allScores[8,1];
        pos10.text=allScores[9,1];
        pos11.text=allScores[10,1];
        pos12.text=allScores[11,1];
        
    }


}




