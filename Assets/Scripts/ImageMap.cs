using System;
using UnityEngine;

[Serializable]
public class ImageMap
{
    public int Id;
    public float Ratio;
    public Line[] Lines;

    public static ImageMap FromJson(string json)
    {
        return JsonUtility.FromJson<ImageMap>(json);
    }
}

[Serializable]
public enum MapColor
{
    Black = 0,
    Red = 1,
    Green = 2,
    Blue = 3,
    Cyan = 4,
    Magenta = 5,
    Yellow = 6
}

[Serializable]
public class Line
{
    public MapColor Color;
    public bool Loop;
    public Point[] Points;
}

[Serializable]
public class Point
{
    public float X;
    public float Y;
}