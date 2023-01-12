// this game is a child game
// dont for get to use coments 
using Raylib_cs;
using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//test kommer att användas för att rätta se om man har rätt
string test = " ";
//extra användes för att testa några saker men också för frågorna om färger 
string extra = " ";

Raylib.InitWindow(1500, 800, "fun games");
Raylib.SetTargetFPS(60);

Font lobsterFont = Raylib.LoadFontEx(@"Lobster-Regular.ttf", 125, null, -1);

string curentsceen = "start";

//de skulle vara en static void och en typkonvertering men kunde inte hita en plats där de behövdes 
//// int kommer att användas bara för att göra en typkonvertering
//// string kommer att användas bara för att göra en typkonvertering
//// string jobig2 = "1";
//// static void Test1(){
////     int jobig = int.Parse(jobig2);
//// }


//Den här klupen med kod används för att göra så att jag för en ändrade i färger på en av texterna.
Color[] textcolors = { Color.SKYBLUE, Color.GREEN, Color.DARKPURPLE, Color.GOLD};
Random generator = new Random();
Color textColor = textcolors[0];






while (!Raylib.WindowShouldClose())
{


    if (curentsceen == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
            curentsceen = "menu";
        }
        Raylib.ClearBackground(Color.GRAY);
        Raylib.DrawTextEx(lobsterFont, "Press enter to start!!!", new Vector2(20, 190), 125, 10, Color.BLACK);
    }

    if (curentsceen == "menu")
    {
        // det gär för så att det inte ändras varje frame
        int whichColor = generator.Next(31);
        if (whichColor >= 27)
        {
            whichColor = generator.Next(textcolors.Length);
            textColor = textcolors[whichColor];
        }
        Raylib.ClearBackground(Color.BLUE); 
        Raylib.DrawTextEx(lobsterFont, "welcome to the best ", new Vector2(20, 15), 80, 40, textColor);
        Raylib.DrawTextEx(lobsterFont, "kids game", new Vector2(20, 75), 80, 40, textColor);
        Raylib.DrawTextEx(lobsterFont, "press A to play math", new Vector2(20, 190), 125, 10, Color.BLACK);
        Raylib.DrawTextEx(lobsterFont, "Press B to play color", new Vector2(20, 290), 125, 10, Color.BLACK);
        Raylib.DrawTextEx(lobsterFont, "Press C to play spelling", new Vector2(20, 390), 125, 10, Color.BLACK);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
        {
            curentsceen = "math";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_B))
        {
            curentsceen = "Color";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_C))
        {
            curentsceen = "spelling";
            extra = "asda";
        }

        
    }
    if(curentsceen == "math"){
        //gjorde så att den kollar om test = "ja" för att inan så hade jag problem 
        //med att ha ta bort frågan och ta fram texten när man hade rätt kommer att användas flera gånger
        if (test != "ja"){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, "What is 4 + 3", new Vector2(20, 190), 125, 10, Color.YELLOW);
        Raylib.DrawTextEx(lobsterFont, "Pleas enter a number", new Vector2(20, 290), 125, 10, Color.YELLOW);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SEVEN)){
            test = "ja";
        }
        if (test == "ja"){
            Raylib.ClearBackground(Color.BLUE);
            Raylib.DrawTextEx(lobsterFont, "Du hade rätt", new Vector2(20, 190), 125, 10, Color.YELLOW);
            Raylib.DrawTextEx(lobsterFont, "press Enter to continued", new Vector2(20, 290), 125, 10, Color.YELLOW);
            Raylib.DrawTextEx(lobsterFont, "press Tap to go back", new Vector2(20, 390), 125, 10, Color.YELLOW);
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB)){
                curentsceen = "menu";
                // test blir nej för att om man inte gör det och går till en annan fråga 
               
                // så kommer att det leda till man har rätt atomatisk 
                test = "nej";
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
                test = "nej";
            }
        }
    }
    if(curentsceen == "Color"){
        if (test!="ja")
        Raylib.ClearBackground(Color.MAGENTA);
        Raylib.DrawTextEx(lobsterFont, "what color is the back ", new Vector2(20, 190), 125, 10, Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, "ground, a blue, b maroon", new Vector2(20, 290), 125, 10, Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, "c magenta, d purple", new Vector2(20, 390), 125, 10, Color.BLUE);
        if (extra == "ja"){
        Raylib.DrawTextEx(lobsterFont, "wrong color try again", new Vector2(20, 490), 125, 10, Color.BLUE);

        }
        //kunde inte hita ett kod för att checka om vad knappen man trykte var inte rätt
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_A)){
        extra = "ja";

        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_B)){
        extra = "ja";
       
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_D)){
        extra = "ja";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_C)){
            test = "ja";

        }
        if (test == "ja"){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, "Du hade rätt", new Vector2(20, 190), 125, 10, Color.YELLOW);
        Raylib.DrawTextEx(lobsterFont, "press Enter to continued", new Vector2(20, 290), 125, 10, Color.YELLOW);
        Raylib.DrawTextEx(lobsterFont, "press Tap to go back", new Vector2(20, 390), 125, 10, Color.YELLOW);
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB)){
            curentsceen = "menu";
            test = "nej";
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
            test = "nej";
            extra = "asd";
        }
        }   
    }
    if(curentsceen == "spelling"){
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTextEx(lobsterFont, "how do you spell, Never", new Vector2(20, 290), 125, 10, Color.YELLOW);
        
    }
    //orkade inte checka alla boxtäver så jag märkte att om man kollar bokstaven R så hade de troligen rätt 
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_R)){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, "Du hade rätt", new Vector2(20, 190), 125, 10, Color.YELLOW);
        Raylib.DrawTextEx(lobsterFont, "press Enter to continued", new Vector2(20, 290), 125, 10, Color.YELLOW);
        Raylib.DrawTextEx(lobsterFont, "press Tap to go back", new Vector2(20, 390), 125, 10, Color.YELLOW);
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB)){
            curentsceen = "menu";
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
            test = "nej";
        }
        }  
    }
