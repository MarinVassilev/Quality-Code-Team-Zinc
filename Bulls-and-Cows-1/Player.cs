﻿using System;

public class Player : IComparable<Player>
{
    private string nickname;
    private int score;

    public Player(string nickname, int score)
    {
        this.Nickname = nickname;
        this.Score = score;
    }

    public string Nickname
    {
        get
        {
            return this.nickname;
        }

        private set
        {
            if (this.nickname == string.Empty)
            {
                throw new ArgumentException("Nickname should have at least 1 symbol!");
            }
            else
            {
                this.nickname = value;
            }
        }
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            this.score = value;
        }
    }

    public int CompareTo(Player otherPlayerScore)
    {
        if (this.Score.CompareTo(otherPlayerScore.Score) == 0)
        {
            return this.Nickname.CompareTo(otherPlayerScore.Nickname);
        }
        else
        {
            return this.Score.CompareTo(otherPlayerScore.Score);
        }
    }

    public override string ToString()
    {
        string result = string.Format("{0,3} | {1}", this.Score, this.Nickname);
        return result;
    }
}