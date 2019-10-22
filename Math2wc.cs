using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Math2wc: MonoBehaviour {

 [System.Serializable]
 public class vector3_double {
  public double x;
  public double y;
  public double z;
 }

 public static float convertInto(float x, float a1, float b1, float a2, float b2) {
  if ((b1 - a1) != 0) {
   return ((b2 - a2) / (b1 - a1)) * (x - a1) + a2;
  }
  return 0;
 }

 public static float min(float[] data) {
  float min = data[0];
  for (int i = 1; i < data.Length; i++) {
   if (data[i] <= min) {
    min = data[i];
   }
  }
  return min;
 }

 public static float max(float[] data) {
  float max = data[0];
  for (int i = 1; i < data.Length; i++) {
   if (data[i] >= max) {
    max = data[i];
   }
  }
  return max;
 }

 public static vector3_double[] SphericalCoordinatesSystem(double longitude, double latitude, double altitude, Transform sphere) {
  double x = altitude * Math.Cos(DegreeToRadian(latitude)) * Math.Cos(DegreeToRadian(longitude));
  double z = altitude * Math.Cos(DegreeToRadian(latitude)) * Math.Sin(DegreeToRadian(longitude));
  double y = altitude * Math.Sin(DegreeToRadian(latitude));

  vector3_double[] result = new vector3_double[2];

  //position vector
  result[0] = new vector3_double();
  result[0].x = sphere.position.x + x;
  result[0].y = sphere.position.y + y;
  result[0].z = sphere.position.z + z;

  //normal vector
  result[1] = new vector3_double();
  result[1].x = x;
  result[1].y = y;
  result[1].z = z;
  return result;
 }

 private static double DegreeToRadian(double angle) {
  return 3.14 * angle / 180.0;
 }

 public static bool CircleRadar(float r, float x1, float z1, float x2, float z2) {
  if (Mathf.Sqrt(Mathf.Pow((x1 - x2), 2) + Mathf.Pow((z1 - z2), 2)) < r) {
   return true;
  } else {
   return false;
  }
 }

 //Get center width height of a rectangle from its corner's coordinates 
 public struct DimensionRect {
  public float width;
  public float height;
  public Vector2 center;
 }
 public static DimensionRect GetDimension(Vector2 point1, Vector2 point2) {
  float width = Mathf.Abs(point2.x - point1.x);
  float height = Mathf.Abs(point2.y - point1.y);
  Vector2 center = new Vector2((point1.x + point2.x) / 2, (point1.y + point2.y) / 2);
  DimensionRect D = new DimensionRect() {
   width = width,
    height = height,
    center = center
  };
  return (D);
 }


}
