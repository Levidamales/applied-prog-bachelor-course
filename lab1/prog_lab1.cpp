#include <iostream>
using namespace std;

struct Point
{
    float x,y;
};

float determ(float x1, float y1, float x2, float y2)
{
    return(x1*y2-x2*y1);
}

int main()
{
    Point a1,b1,a2,b2;
    float z;
    cout<<"1st line"<<endl<<"  Enter X and Y for point A: ";
    cin>>a1.x>>a1.y;
    cout<<"  Enter X and Y for point B: ";
    cin>>b1.x>>b1.y;
    
    cout<<"2nd line"<<endl<<"  Enter X and Y for point A: ";
    cin>>a2.x>>a2.y;
    cout<<"  Enter X and Y for point B: ";
    cin>>b2.x>>b2.y;
    z=determ(
    determ(a1.x,1,b1.x,1),
    determ(a1.y,1,b1.y,1),
    determ(a2.x,1,b2.x,1),
    determ(a2.y,1,b2.y,1));
    if(z==0)
        cout<<"No intersection";
    else
    {
        Point *c = new Point;
        c->x=determ(
        determ(a1.x,a1.y,b1.x,b1.y),
        determ(a1.x,1,b1.x,1),
        determ(a2.x,a2.y,b2.x,b2.y),
        determ(a2.x,1,b2.x,1))/z;
        c->y=determ(
        determ(a1.x,a1.y,b1.x,b1.y),
        determ(a1.y,1,b1.y,1),
        determ(a2.x,a2.y,b2.x,b2.y),
        determ(a2.y,1,b2.y,1))/z;
        cout << "Intersection point is (" << c->x << ";" << c->y <<")";
    }
    return 0;
}