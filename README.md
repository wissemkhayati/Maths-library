# Maths-library
A bunch of mathematical functions accumulated during my daily development.

## Methods
* Convert a value from his real segment to another segment. For example 5 in [1..10] equals to 50 in [1..100]
```
float convertInto(float x, float a1, float b1, float a2, float b2)
```
* abdcd
```
float convertToInterval(float interval, float minA, float maxA, float minB, float maxB)
```
* Get minimum value from array
```
float min(float[] data)
```
* Get maximum value from array
```
float max(float[] data)
```
* Convert geographic coordinate system to cartesian 
```
vector3_double[] SphericalCoordinatesSystem(double longitude, double latitude, double altitude, Transform sphere)
```
* Convert degree to radian
```
double DegreeToRadian(double angle)
```
* Return if [x2,z2] in the circle of position [x1,z1] with radius r 
```
bool CircleRadar(float r, float x1, float z1, float x2, float z2)
```
* abdcd
```
DimensionRect GetDimension(Vector2 point1, Vector2 point2)
```
* abdcd
```
GetScale(int width, int height, Vector2 scalerReferenceResolution, float scalerMatchWidthOrHeight)
```
