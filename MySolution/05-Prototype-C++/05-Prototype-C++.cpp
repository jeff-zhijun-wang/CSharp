// 05-Prototype-C++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

using namespace std;

class Stooge {
public:
	virtual Stooge* clone() = 0;
	virtual void slap_stick() = 0;
};

class Larry : public Stooge {
public:
	Stooge* clone() { return new Larry; }
	void slap_stick() {
		cout << "Larry: poke eyes\n";
	}
};

class Moe : public Stooge {
public:
	Stooge* clone() { return new Moe; }
	void slap_stick() {
		cout << "Moe: slap head\n";
	}
};

class Curly : public Stooge {
public:
	Stooge* clone() { return new Curly; }
	void slap_stick() {
		cout << "Curly: suffer abuse\n";
	}
};


class Factory {
public:
	static Stooge* make_stooge(int choice);
private:
	static Stooge* s_prototypes[4];
};

Stooge* Factory::s_prototypes[] = {
   0, new Larry, new Moe, new Curly
};

Stooge* Factory::make_stooge(int choice) {
	return s_prototypes[choice]->clone(); //clone new Larry 's 
}



int main()
{
	vector<Stooge *> roles;
	int             choice;

	while (true) {
		cout << "Larry(1) Moe(2) Curly(3) Go(0): ";
		cin >> choice;
		if (choice == 0)
			break;
		roles.push_back(Factory::make_stooge(choice));
	}

	for (int i = 0; i < roles.size(); ++i)
		roles[i]->slap_stick();
	for (int i = 0; i < roles.size(); ++i)
		delete roles[i];
    std::cout << "Hello World!\n"; 
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
