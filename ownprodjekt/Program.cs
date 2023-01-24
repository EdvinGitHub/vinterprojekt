// this game is a child game
// dont for get to use coments 
using Raylib_cs;
using System.Numerics;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

//test kommer att användas för att rätta se om man har rätt
string test = "nej";
//extra användes för att testa några saker men också för frågorna om färger 
string extra = "nej";
string test3 = "you were right \npress Enter to continued \npress Tab to go back";


// List<string> test4 = new List<string>();
// test4.Add(" what color is the back\n ground, z blue, x maroon\n c magenta, v purple");
// test4.Add("what color is the back\n z green, x blue\n c red, v gray");
// test4.Add("what color is the back\n ");
// int randomQ;
// int test5;
// " what color is the back\n ground, z blue, x maroon\n c magenta, v purple";
int whichColor;


Raylib.InitWindow(1600, 800, "fun games");
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
    Raylib.BeginDrawing();

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
        whichColor = generator.Next(31);
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
            Raylib.DrawTextEx(lobsterFont, test3, new Vector2(20, 190), 125, 10, Color.YELLOW);
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
        if (test == "nej"){
        Raylib.ClearBackground(Color.MAGENTA);
        Raylib.DrawTextEx(lobsterFont, " what color is the back\n ground, z blue, x maroon\n c magenta, v purple", new Vector2(20, 90), 90, 10, Color.WHITE);
        }
        if (extra == "ja"){
            Raylib.DrawTextEx(lobsterFont, " wrong color try again", new Vector2(20, 490), 125, 10, Color.WHITE);

        }
        //kunde inte hita ett kod för att checka om vad knappen man trykte var inte rätt
        if (Raylib.IsKeyDown(KeyboardKey.KEY_Z)){
            extra = "ja";

        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_V)){
            extra = "ja";
       
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_X)){
            extra = "ja";
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_C)){
            test = "ja";
            extra = "nej";

        }
        if (test == "ja"){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, test3, new Vector2(20, 190), 125, 10, Color.YELLOW);
       
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
        if(test == "nej"){
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTextEx(lobsterFont, "how do you spell, Never", new Vector2(20, 290), 125, 10, Color.YELLOW);
        }
    //orkade inte checka alla boxtäver så jag märkte att om man kollar bokstaven R så hade de troligen rätt 
        // if (Raylib.IsKeyPressed(KeyboardKey.KEY_N)){
            
        //     if (Raylib.IsKeyPressed(KeyboardKey.KEY_E)){

        //         if (Raylib.IsKeyPressed(KeyboardKey.KEY_V)){

        //             if (Raylib.IsKeyPressed(KeyboardKey.KEY_E)){

         if (Raylib.IsKeyPressed(KeyboardKey.KEY_R)){
            test = "ja";
                            
        }
        //             }
        //         }          
        //     }
        // }    
        if (test == "ja"){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, test3, new Vector2(20, 190), 125, 10, Color.YELLOW);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB)){
            curentsceen = "menu";
            test = "nej";
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
            test = "nej";

        }
        }   
    }
    
        
        Raylib.EndDrawing();
    }
