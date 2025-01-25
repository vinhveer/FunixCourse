#include <iostream>
using namespace std;

class Vehicle {
public:
    virtual void startEngine() = 0; // Pure virtual function
    virtual void stopEngine() = 0; // Pure virtual function
};

class Car : public Vehicle {
public:
    void startEngine() override {
        cout << "Car engine started." << endl;
    }

    void stopEngine() override {
        cout << "Car engine stopped." << endl;
    }
};

int main() {
    Vehicle *myCar = new Car();
    myCar->startEngine();
    myCar->stopEngine();
    delete myCar;
    return 0;
}
