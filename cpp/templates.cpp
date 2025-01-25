#include <iostream>

template <typename T>
T maxValue(T a, T b)
{
	return (a > b) ? a : b;
}

template <typename T>
T minValue(T a, T b)
{
	return (a < b) ? a : b;
}

int main()
{
	// Test with int
	std::cout << "Max(5, 10): " << maxValue(5, 10) << std::endl;
	std::cout << "Min(5, 10): " << minValue(5, 10) << std::endl;
	
	// Test with double
	std::cout << "Max(5.3, 10.2): " << maxValue(5.3, 10.2) << std::endl;
	std::cout << "Min(5.45, 10.5): " << minValue(5.45, 10.5) << std::endl;
	
	return 0;
}
