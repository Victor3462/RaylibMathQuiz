using System;
using Raylib_cs;
using System.Collections.Generic;

Raylib.InitWindow(800, 600, "Math Quiz");
Raylib.SetTargetFPS(60);

Random generator = new Random();

Color backroundColor = new Color(63, 100, 126, 100);

string currentMenu = "start";

int points = 0;

int framesTimer = 0;

int time = 30;

void startTimer()
{
    framesTimer++;
    if (framesTimer == 60)
    {
        time--;
        framesTimer = 0;
    }
}


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

    if (currentMenu != "start" && currentMenu != "gameOver")
    {
        Raylib.DrawText($"{time}", 25, 25, 125, Color.RED);
        startTimer();
    }

    if (time == 0)
    {
        currentMenu = "gameOver";
    }

    if (currentMenu == "playingQuiz")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 1:", 215, 75, 75, Color.RED);

        Raylib.DrawText("4 + 6 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 46   2: 10   3: 11", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question2";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question2";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question2";
        }

    }

    else if (currentMenu == "question2")
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

    else if (currentMenu == "question3")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 3:", 215, 75, 75, Color.RED);

        Raylib.DrawText(" 40 / 4 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 10   2: 4   3: 400", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question4";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question4";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question4";
        }

    }

    else if (currentMenu == "question4")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 4:", 215, 75, 75, Color.RED);

        Raylib.DrawText(" 7 x 8 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 48  2: 78   3: 56", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question5";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question5";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question5";
            points++;
        }

    }

    else if (currentMenu == "question5")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 5:", 215, 75, 75, Color.RED);

        Raylib.DrawText(" 24 - 9 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 15  2: 18   3: 12", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question6";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question6";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question6";
        }

    }

    else if (currentMenu == "question6")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 6:", 215, 75, 75, Color.RED);

        Raylib.DrawText(" 13 x 4 = ?", 300, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 52  2: 69   3: 49", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question7";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question7";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question7";
        }

    }

    else if (currentMenu == "question7")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 7:", 215, 75, 75, Color.RED);

        Raylib.DrawText(" 56 / 7 = ?", 250, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 16  2: 8  3: 12", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question8";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question8";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question8";
        }

    }

    else if (currentMenu == "question8")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 8:", 215, 75, 75, Color.RED);

        Raylib.DrawText(" 7x + 4x - 3x = ?", 200, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 12x  2: 7x   3: 8x", 150, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question9";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question9";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question9";
            points++;
        }

    }

    else if (currentMenu == "question9")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 9:", 175, 75, 75, Color.RED);

        Raylib.DrawText(" 46 x 0 = ?", 275, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 23  2: 46   3: 0", 175, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "question10";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "question10";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "question10";
            points++;
        }

    }

    else if (currentMenu == "question10")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("Question 10:", 200, 75, 75, Color.RED);

        Raylib.DrawText(" 25 / 2 + 10 = ?", 225, 225, 50, Color.WHITE);

        Raylib.DrawText("1: 25  2: 22,5  3: 18,5", 150, 350, 50, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
        {
            currentMenu = "gameOver";
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            currentMenu = "gameOver";
            points++;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
        {
            currentMenu = "gameOver";
        }

    }

    else if (currentMenu == "gameOver")
    {

        Raylib.ClearBackground(backroundColor);

        Raylib.DrawText("GAME OVER", 175, 75, 75, Color.RED);

        Raylib.DrawText($"You got {points}/10 points", 175, 225, 50, Color.WHITE);

    }



    Raylib.EndDrawing();
}