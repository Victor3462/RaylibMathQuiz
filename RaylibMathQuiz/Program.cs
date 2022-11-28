using System;
using Raylib_cs;
using System.Collections.Generic;

Raylib.InitWindow(800, 600, "Math Quiz");
Raylib.SetTargetFPS(60);

Random generator = new Random();

Color backroundColor = new Color(63, 100, 126, 100);

string currentMenu = "start";

int points = 0;


while (!Raylib.WindowShouldClose())
{

    Raylib.BeginDrawing();

    if (currentMenu == "start")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Math Quiz", 215, 125, 75, Color.RED);
        Raylib.DrawText("PRESS SPACE TO START", Raylib.GetScreenWidth() / 3 - 25, 250, 25, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            currentMenu = "playingQuiz";
        }

    }

    if (currentMenu == "playingQuiz")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 1:", 215, 75, 75, Color.RED);

        Raylib.DrawText("4 + 6 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 46   2: 10   3: 11", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            Raylib.WaitTime(1);
            currentMenu = "question2";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            Raylib.WaitTime(1);
            currentMenu = "question2";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            Raylib.WaitTime(1);
            currentMenu = "question2";
        }

    }

    if (currentMenu == "question2")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 2:", 215, 75, 75, Color.RED);

        Raylib.DrawText("20 - 7 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 27   2: 15   3: 13", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question3";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question3";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question3";
            points++;
        }

    }

    if (currentMenu == "question3")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 3:", 215, 75, 75, Color.RED);

        Raylib.DrawText(" 40 / 4 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 10   2: 4   3: 400", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question3";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question3";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question3";
        }

    }



    Raylib.EndDrawing();
}