#include <iostream>

class Rectangle
{
private:
	double length;
	double width;
	
public:
	Rectangle(double l, double w) : length(l), width(w) {}
	
	friend double area(const Rectangle& rect);
	
	friend double perimeter(const Rectangle& rect);
};

double area(const Rectangle& rect)
{
	return rect.length * rect.width;	
}

double perimeter(const Rectangle& rect)
{
	return 2 * (rect.length + rect.width);
}

int main()
{
	Rectangle rect(10.5, 4.5);
	
	std::cout << "Area: " << area(rect) << std::endl;
	std::cout << "Perimeter: " << perimeter(rect) << std::endl;
	
	return 0;
}
