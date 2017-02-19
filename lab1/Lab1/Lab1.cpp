#include "stdafx.h"
#include <iostream>
using namespace std;

struct Point
{
	float x, y;
};
float Determine(float x1, float y1, float x2, float y2)
{
	return(x1*y2 - x2*y1);
}
Point* Intersection(Point a1, Point b1, Point a2, Point b2)
{
	float z = Determine(
		Determine(a1.x, 1, b1.x, 1),
		Determine(a1.y, 1, b1.y, 1),
		Determine(a2.x, 1, b2.x, 1),
		Determine(a2.y, 1, b2.y, 1));
	if (z == 0)
	{
		return nullptr;
	}
		
	else
	{
		Point *c = new Point;
		c->x = Determine(
			Determine(a1.x, a1.y, b1.x, b1.y),
			Determine(a1.x, 1, b1.x, 1),
			Determine(a2.x, a2.y, b2.x, b2.y),
			Determine(a2.x, 1, b2.x, 1)) / z;
		c->y = Determine(
			Determine(a1.x, a1.y, b1.x, b1.y),
			Determine(a1.y, 1, b1.y, 1),
			Determine(a2.x, a2.y, b2.x, b2.y),
			Determine(a2.y, 1, b2.y, 1)) / z;
		return c;
	}
}

int main()
{
	Point a, b, c, d,*result;
	cout << "1st line\n  Enter X and Y for point A: ";
	cin >> a.x >> a.y;
	cout << "  Enter X and Y for point B: ";
	cin >> b.x >> b.y;

	cout << "2nd line" << endl << "  Enter X and Y for point A: ";
	cin >> c.x >> c.y;
	cout << "  Enter X and Y for point B: ";
	cin >> d.x >> d.y;
	result = Intersection(a, b, c, d);
	if(result==nullptr)
		cout << "No intersection\n";
	else
		cout << "Intersection point is (" << result->x << ";" << result->y << ")\n";
	system("pause");
    return 0;
}