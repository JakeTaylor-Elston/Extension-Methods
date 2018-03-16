using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExtensions
{
    public static Vector3 AddVector(this Vector3 originalVector, float xValue, float yValue, float zValue)
    {
        return new Vector3(originalVector.x + xValue, originalVector.y + yValue, originalVector.z + zValue);
    }

    public static Vector3 GetDirectionTo(this Vector3 originPos, Vector3 destinationPos)
    {
        return Vector3.Normalize(destinationPos - originPos);
    }

    public static Vector3 GetMidpointTo(this Vector3 startPos, Vector3 endPos)
    {
        return (startPos + endPos)/2;
    }
}