class Animal {
public:
    string name;

    void sayHello() {
        cout << "Hello, I am " << name << endl;
    }
};

int main() {
    Animal cat;
    cat.name = "Tom";
    cat.sayHello(); // In ra: Hello, I am Tom
    return 0;
}
