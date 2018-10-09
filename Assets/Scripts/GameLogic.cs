using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic{

    int min, max;
    int guess;
    bool mydebug = false;
    //deklaration und zuweisung
    //Tag ist der name der klasse um zu wissen aus welcher klasse der debug kommt
    string TAG = "GameLogic";

    //konstruktor
    public GameLogic() {
        InitGame();
    }

    private void InitGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
    }

    public string StartGame()
    {
        MyDebug("--start Game");
        string msg = "Hallo \n" +
                     "Spielen wir ein Spiel! \n" +
                     "Du wählst eine Zahl zwischen " + min + " und " + max +"\n" +
                     "und ich rate solage bis ich sie gefunden habe :) \n" +
                     "Ist deine Zahl kleiner als mein Vorschlag tippe: \n" +
                     "\'game lower\' \n" +
                     "Ist deine Zahl größer als mein Vorschlag tippe: \n" +
                     "\'game higher\' \n" +
                     "habe ich sie gefunden tippe: \n" +
                     "\'game end\' \n" + 
                     "Zahl gemerkt? Mein Vorschlag ist: " + guess;
        return msg;
    }

    public void SetValues(int cmin, int cmax)
    {
        min = cmin;
        max = cmax;
        guess = (min + max) / 2;
        MyDebug("--SetValues min: " + min +" max: " +max );
    }
    
    public void AdaptMax()
    {
        max = guess;
        CalcGuess();
    }

    public void AdaptMin()
    {
        min = guess;
        CalcGuess();
    }

    private void CalcGuess()
    {
        guess = (min + max) / 2;
    }

    public string NextGuess()
    {
        MyDebug("--NextGuess");
        return "Mein Vorschlag ist: " + guess;
    }

    public void EndGame()
    {
        InitGame();
    }

    //void= keine rückgabe..bei string=string, int=int, Void=nix...Debug massages werden nicht geprintet
    void MyDebug(string msg)
    {
        if (mydebug)
        {
            Debug.Log(TAG+": "+msg);
        }
    }


}
