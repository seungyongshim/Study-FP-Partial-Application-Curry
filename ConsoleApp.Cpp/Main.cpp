#include <iostream>
#include <functional>
using namespace std;
using namespace placeholders;

int main()
{
	auto f = [](int x, int y, int z) { return x * y + z; };

	auto c1 = bind(f, 2, _1, _2);
	auto c2 = bind(c1, 3, _1);
	auto c3 = bind(c2, 5);

	cout << "Curry: " << c3() << endl;

	auto pa = bind(f, _1, 3, 5);

	cout << "PA: " << pa(2) << endl;

}